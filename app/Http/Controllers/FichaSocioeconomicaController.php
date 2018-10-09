<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Validation\Rule;
use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Crypt;
use App\Trabajador,App\FichaSocioeconomica,App\Casaparte,App\Tipovivienda,App\Construccionmaterial,App\Centromedico,App\Frecuenciamedico,App\Frecuenciaexamen;
use View;
use Session;
use Hashids;


class FichaSocioeconomicaController extends Controller
{
	public function actionModificarFichaSocioeconomica($idfichasocioeconomica,$idopcion,$idtrabajador,Request $request)
	{
			$cabecera            	 	 		 =	Fichasocioeconomica::find($idfichasocioeconomica);
			$cabecera->tipovivienda_id  		 = 	$request['tipovivienda_id'];
			$cabecera->casaparte_id 	     	 =  $request['casaparte_id'];
			$cabecera->construccionmaterial_id 	 =  $request['construccionmaterial_id'];
			$cabecera->servicio_id 	 		     =  $request['servicio_id'];
			$cabecera->centromedico_id 	 		 = 	$request['centromedico_id'];
			$cabecera->frecuenciamedico_id  	 =	$request['frecuenciamedico_id'];
			$cabecera->frecuenciaexamen_id   	 = 	$request['frecuenciaexamen_id'];
			$cabecera->enfermedad_id   			 = 	$request['enfermedad_id'];
			$cabecera->religion   			 	 = 	$request['religion'];
			$cabecera->gruposanguineo 		 	 = 	$request['gruposanguineo'];
			$cabecera->tallapantalon 		 	 =	$request['tallapantalon'];
			$cabecera->tallacamisa 		 		 =	$request['tallacamisa'];
			$cabecera->tallapolo 	 	 		 = 	$request['tallapolo'];
			$cabecera->tallazapato		 		 =	$request['tallazapato'];
			$cabecera->callesreferencia		 	 =	$request['callesreferencia'];
			$cabecera->telefonofijo 		 	 = 	$request['telefonofijo'];
			$cabecera->telefonoemergencia 		 = 	$request['telefonoemergencia'];
			$cabecera->referenciafamiliar 		 = 	$request['referenciafamiliar'];
			$cabecera->ingresomensual 			 = 	$request['ingresomensual'];
			$cabecera->otroingreso 		 	     = 	$request['otroingreso'];
			$cabecera->negociopropio             = 	$request['negociopropio'];
			$cabecera->deudas 	 			     = 	$request['deudas'];
			$cabecera->estadoconstruccion 	 	 = 	$request['estadoconstruccion'];
			$cabecera->laboratorioclinico 	 	 = 	$request['laboratorioclinico'];
			$cabecera->observacion 	 	         = 	$request['observacion'];
			$cabecera->save();

 			return Redirect::to('/ficha-socioeconomica-trabajador/'.$idopcion.'/'.$idtrabajador)->with('bienhecho', 'FichaSocioeconomica'.$request['nombre'].' '.$request['apellidopaterno'].' Modificado con éxito');
	}


	public function actionFichaSocioeconomica($idopcion,$idtrabajador,Request $request)
	{
		$idtrabajadorsd  = $idtrabajador;
	    $idtrabajador = $this->funciones->decodificar($idtrabajador);

		if($_POST)
		{
			/**** Validaciones laravel ****/
			$this->validate($request, [
	            'id' => 'unique:fichasocioeconomicas',
			], [
            	'id.unique' => 'Ficha ya registrada',
        	]);
			/******************************/ 

 

			$idfichasocioeconomica 		 	     = $this->funciones->getCreateId('fichasocioeconomicas');
			
			$cabecera            	 	 		 =	new Fichasocioeconomica;
			$cabecera->id 	     	 	 		 =  $idfichasocioeconomica;
			$cabecera->trabajador_id  		 	 = 	$idtrabajador;
			$cabecera->tipovivienda_id  		 = 	$request['tipovivienda_id'];
			$cabecera->construccionmaterial_id 	 =  $request['construccionmaterial_id'];
			$cabecera->centromedico_id 	 		 = 	$request['centromedico_id'];
			$cabecera->frecuenciamedico_id  	 =	$request['frecuenciamedico_id'];
			$cabecera->frecuenciaexamen_id   	 = 	$request['frecuenciaexamen_id'];
			$cabecera->religion   			 	 = 	$request['religion'];
			$cabecera->gruposanguineo 		 	 = 	$request['gruposanguineo'];
			$cabecera->tallapantalon 		 	 =	$request['tallapantalon'];
			$cabecera->tallacamisa 		 		 =	$request['tallacamisa'];
			$cabecera->tallapolo 	 	 		 = 	$request['tallapolo'];
			$cabecera->tallazapato		 		 =	$request['tallazapato'];
			$cabecera->callesreferencia		 	 =	$request['callesreferencia'];
			$cabecera->telefonofijo 		 	 = 	$request['telefonofijo'];
			$cabecera->telefonoemergencia 		 = 	$request['telefonoemergencia'];
			$cabecera->referenciafamiliar 		 = 	$request['referenciafamiliar'];
			$cabecera->ingresomensual 			 = 	$request['ingresomensual'];
			$cabecera->otroingreso 		 	     = 	$request['otroingreso'];
			$cabecera->negociopropio             = 	$request['negociopropio'];
			$cabecera->deudas 	 			     = 	$request['deudas'];
			$cabecera->estadoconstruccion 	 	 = 	$request['estadoconstruccion'];
			$cabecera->laboratorioclinico 	 	 = 	$request['laboratorioclinico'];
			$cabecera->observacion 	 	         = 	$request['observacion'];
			$cabecera->save();


			// Llenamos Tabla DetalleFichaServicios

			$horariotrabajador 		= 	Horariotrabajador::all('id','luh','lud','hlu','rhlu','mah','mad','hma','rhma',
												'mih','mid','hmi','rhmi','juh','jud','hju','rhju',
												'vih','vid','hvi','rhvi','sah','sad','hsa','rhsa',
												'doh','dod','hdo','rhdo','activo','trabajador_id','semana_id')
										->where('semana_id','=',$idsemana)
										->toArray();

			DB::table('horariotrabajadoresclonados')->insert($horariotrabajador);
			
						dd($request['casaparte']);







 			return Redirect::to('/ficha-socioeconomica-trabajador/'.$idopcion.'/'.$idtrabajadorsd)->with('bienhecho', 'FichaSocioeconomica'.$request['nombre'].' '.$request['apellidopaterno'].' registrado con éxito');

		}else{

			$listafichasocioeconomica 		= Fichasocioeconomica::where('trabajador_id','=' , $idtrabajador)->get();
			
		    $trabajador 					= Trabajador::where('id', $idtrabajador)->first();
		 
			$tipovivienda 				 	= Tipovivienda::get(); 
			$casaparte 				        = Casaparte::get(); 

			$construccionmaterial 		    = Construccionmaterial::get(); 

			$servicio 					 	= DB::table('servicios')->pluck('descripcion','id')->toArray();
			$comboservicio					= array('' => "Seleccione:") + $servicio;

			$centromedico 					= Centromedico::get(); 
	
			$frecuenciamedico 			    = Frecuenciamedico::get(); 
			
			$frecuenciaexamen 				= Frecuenciaexamen::get();


			$enfermedad 					= DB::table('enfermedades')->pluck('descripcion','id')->toArray();
			$comboenfermedad				= array('' => "Seleccione enfermedad:") + $enfermedad;


	        return View::make('trabajador/fichasocioeconomicatrabajador', 
	        				[

	        					'listafichasocioeconomica'  	    	=> $listafichasocioeconomica,
	        					'trabajador'  	    					=> $trabajador,
	        					'idopcion'  	    					=> $idopcion,
	        					'tipovivienda'  	    				=> $tipovivienda,
	        					'casaparte'  	    					=> $casaparte,
	        					'construccionmaterial'  	    		=> $construccionmaterial,
	        					'comboservicio'  	    				=> $comboservicio,
	        					'centromedico' 							=> $centromedico,
	        					'frecuenciamedico' 						=> $frecuenciamedico,
						  		'frecuenciaexamen' 						=> $frecuenciaexamen,
						  		'comboenfermedad' 						=> $comboenfermedad,
						  		
	        				]);
		}
	}

	public function actionFichaSocioeconomicaAjax(Request $request)
	{

		

		$id   							= $request['id'];
		$idopcion   					= $request['idopcion'];
		$idtrabajador   				= $request['idtrabajador'];

		$fichasocioeconomica 		    = Fichasocioeconomica::where('id','=' , $id)->first();


		$tipovivienda 				 	= DB::table('tipoviviendas')->pluck('descripcion','id')->toArray();
		$combotipovivienda 		 	    = array($fichasocioeconomica->tipovivienda_id => $fichasocioeconomica->tipovivienda->descripcion) + $tipovivienda;

		$casaparte 				        = DB::table('casapartes')->pluck('descripcion','id')->toArray();
		$combocasaparte 		 	    = array($fichasocioeconomica->tipovivienda_id => $fichasocioeconomica->tipovivienda->descripcion) + $tipovivienda;

		$construccionmaterial 		    = DB::table('construccionmateriales')->pluck('descripcion','id')->toArray();
		$comboconstruccionmaterial	    = array($fichasocioeconomica->construccionmaterial_id => $fichasocioeconomica->construccionmaterial->descripcion) + $construccionmaterial;

		$servicio 					 	= DB::table('servicios')->pluck('descripcion','id')->toArray();
		$comboservicio					= array($fichasocioeconomica->servicio_id => $fichasocioeconomica->servicio->descripcion) + $servicio;

		$centromedico 					= DB::table('centromedicos')->pluck('descripcion','id')->toArray();
		$combocentromedico				= array($fichasocioeconomica->centromedico_id => $fichasocioeconomica->centromedico->descripcion) + $centromedico;

		$frecuenciamedico 			    = DB::table('frecuenciamedicos')->pluck('descripcion','id')->toArray();
		$combofrecuenciamedico			= array($fichasocioeconomica->frecuenciamedico_id => $fichasocioeconomica->frecuenciamedico->descripcion) + $frecuenciamedico;

		$frecuenciaexamen 				= DB::table('frecuenciaexamenes')->pluck('descripcion','id')->toArray();
		$combofrecuenciaexamen		    = array($fichasocioeconomica->frecuenciaexamen_id => $fichasocioeconomica->frecuenciaexamen->descripcion) + $frecuenciaexamen;

		$enfermedad 					= DB::table('enfermedades')->pluck('descripcion','id')->toArray();
		$comboenfermedad				= array($fichasocioeconomica->enfermedad_id => $fichasocioeconomica->enfermedad->descripcion) + $enfermedad;



		return View::make('trabajador/ajax/editfs',
						 [
	        					'id'  	    							=> $id,
	        					'idopcion'  	    					=> $idopcion,
	        					'idtrabajador'  	    				=> $idtrabajador,
	        					'combotipovivienda'  	    			=> $combotipovivienda,
	        					'combocasaparte'  	    				=> $combocasaparte,
	        					'comboconstruccionmaterial'  	    	=> $comboconstruccionmaterial,
	        					'comboservicio'  	    				=> $comboservicio,
	        					'combocentromedico' 					=> $combocentromedico,					 
						  		'combofrecuenciamedico' 				=> $combofrecuenciamedico,
						  		'combofrecuenciaexamen' 				=> $combofrecuenciaexamen,
						  		'comboenfermedad' 						=> $comboenfermedad,
						  		'fichasocioeconomica' 					=> $fichasocioeconomica,
						  		
						 ]);
	}	
}
