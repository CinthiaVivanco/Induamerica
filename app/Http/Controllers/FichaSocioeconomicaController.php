<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Validation\Rule;
use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Crypt;
use App\Trabajador,App\FichaSocioeconomica;
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
			$cabecera->afiliado 		 		 =	$request['afiliado'];
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
			$cabecera->activo 		 	 		 = 	$request['activo'];
			$cabecera->save();

 			return Redirect::to('/ficha-socioeconomica-trabajador/'.$idopcion.'/'.$idtrabajador)->with('bienhecho', 'FichaSocioeconomica'.$request['nombre'].' '.$request['apellidopaterno'].' Modificado con ésxito');
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
			$cabecera->afiliado 		 		 =	$request['afiliado'];
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
			$cabecera->activo 		 	 		 = 	$request['activo'];

			$cabecera->save();
 			return Redirect::to('/ficha-socioeconomica-trabajador/'.$idopcion.'/'.$idtrabajadorsd)->with('bienhecho', 'FichaSocioeconomica'.$request['nombre'].' '.$request['apellidopaterno'].' registrado con éxito');

		}else{

			$listafichasocioeconomica 		= Fichasocioeconomica::where('trabajador_id','=' , $idtrabajador)->get();
			
		    $trabajador 					= Trabajador::where('id', $idtrabajador)->first();
		    
			$tipovivienda 				 	= DB::table('tipoviviendas')->pluck('descripcion','id')->toArray();
			$combotipovivienda 		 	    = array('' => "Seleccione Tipo Vivienda") + $tipovivienda;

			$casaparte 				        = DB::table('casapartes')->pluck('descripcion','id')->toArray();
			$combocasaparte 		 	    = array('' => "Cuenta con:") + $casaparte;

			$construccionmaterial 		    = DB::table('construccionmateriales')->pluck('descripcion','id')->toArray();
			$comboconstruccionmaterial	    = array('' => "Material de Construccciòn") + $construccionmaterial;

			$servicio 					 	= DB::table('servicios')->pluck('descripcion','id')->toArray();
			$comboservicio					= array('' => "Servicios") + $servicio;

			$centromedico 					= DB::table('centromedicos')->pluck('descripcion','id')->toArray();
			$combocentromedico				= array('' => "¿Dònde se atiende?") + $centromedico;

			$frecuenciamedico 			    = DB::table('frecuenciamedicos')->pluck('descripcion','id')->toArray();
			$combofrecuenciamedico			= array('' => "Frecuencia con la que asiste al médico") + $frecuenciamedico;

			$frecuenciaexamen 				= DB::table('frecuenciaexamenes')->pluck('descripcion','id')->toArray();
			$combofrecuenciaexamen		    = array('' => "Con que frecuencia realiza exámenes de laboratorio clínico") + $frecuenciaexamen;

			$enfermedad 					= DB::table('enfermedades')->pluck('descripcion','id')->toArray();
			$comboenfermedad				= array('' => "¿Dònde se atiende?") + $enfermedad;


	        return View::make('trabajador/fichasocioeconomicatrabajador', 
	        				[

	        					'listafichasocioeconomica'  	    	=> $listafichasocioeconomica,
	        					'trabajador'  	    					=> $trabajador,
	        					'idopcion'  	    					=> $idopcion,
	        					'combotipovivienda'  	    			=> $combotipovivienda,
	        					'combocasaparte'  	    				=> $combocasaparte,
	        					'comboconstruccionmaterial'  	    	=> $comboconstruccionmaterial,
	        					'comboservicio'  	    				=> $comboservicio,
	        					'combocentromedico' 					=> $combocentromedico,					 
						  		'combofrecuenciamedico' 				=> $combofrecuenciamedico,
						  		'combofrecuenciaexamen' 				=> $combofrecuenciaexamen,
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

		return View::make('trabajador/ajax/editdh',
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
						 ]);
	}	
}
