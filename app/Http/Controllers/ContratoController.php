<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Validation\Rule;
use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Crypt;
use App\Trabajador, App\Contrato;
use View;
use Session;
use Hashids;


class ContratoController extends Controller
{
	public function actionModificarContrato($idcontrato,$idopcion,$idtrabajador,Request $request)
	{
			$cabecera            	 	 		 =	Contrato::find($idcontrato);
			$cabecera->fechainicio 				 = 	$request['fechainicio'];
			$cabecera->fechafin 				 = 	$request['fechafin'];
			$cabecera->empresa 	 		 		 =  $request['empresa'];
			$cabecera->observacion 	 		 	 =  $request['observacion'];
			$cabecera->estado 		 	 		 = 	$request['estado'];
			$cabecera->tipocontratotrabajador_id = 	$request['tipocontratotrabajador_id'];

			$cabecera->save();

 			return Redirect::to('/ficha-contrato-trabajador/'.$idopcion.'/'.$idtrabajador)->with('bienhecho', 'Contrato'.$request['nombre'].' '.$request['apellidopaterno'].' Modificado con éxito');
	}


	public function actionContrato($idopcion,$idtrabajador,Request $request)
	{
		$idtrabajadorsd  = $idtrabajador;
	    $idtrabajador = $this->funciones->decodificar($idtrabajador);

		if($_POST)
		{
			/**** Validaciones laravel ****/
			$this->validate($request, [
	            'id' => 'unique:contratos',
			], [
            	'id.unique' => 'Contrato ya registrado',
        	]);
			/******************************/

			$idcontrato 		 			 = $this->funciones->getCreateId('contratos');
			
			$cabecera            	 	 		 =	new Contrato;
			$cabecera->id 	     	 	 		 =  $idcontrato;
			$cabecera->trabajador_id  		 	 = 	$idtrabajador;
			$cabecera->fechainicio 				 = 	$request['fechainicio'];
			$cabecera->fechafin 				 = 	$request['fechafin'];
			$cabecera->empresa 	 		 		 =  $request['empresa'];
			$cabecera->observacion 	 		 	 =  $request['observacion'];
			$cabecera->estado 		 	 		 = 	$request['estado'];
			$cabecera->tipocontratotrabajador_id = 	$request['tipocontratotrabajador_id'];

			$cabecera->save();
 			return Redirect::to('/ficha-contrato-trabajador/'.$idopcion.'/'.$idtrabajadorsd)->with('bienhecho', 'Contrato'.$request['nombre'].' '.$request['apellidopaterno'].' registrado con éxito');

		}else{

			$listacontrato 		    		= Contrato::where('trabajador_id','=' , $idtrabajador)->get();
			
		    $trabajador 					= Trabajador::where('id', $idtrabajador)->first();
		    
			$tipocontratotrabajador 		= DB::table('tipocontratotrabajadores')->pluck('descripcion','id')->toArray();
			$combotipocontratotrabajador  	= array('' => "Seleccione Tipo Contrato") + $tipocontratotrabajador;


	        return View::make('trabajador/contratotrabajador', 
	        				[

	        					'listacontrato'  	    		=> $listacontrato,
	        					'trabajador'  	    			=> $trabajador,
	        					'idopcion'  	    			=> $idopcion,
	        					'combotipocontratotrabajador'  	=> $combotipocontratotrabajador,
	        				]);
	        					
		}
	}

	public function actionContratoAjax(Request $request)
	{

		$id   							= $request['id'];
		$idopcion   					= $request['idopcion'];
		$idtrabajador   				= $request['idtrabajador'];


		$contrato 		    						= Contrato::where('id','=' , $id)->first();

		$tipocontratotrabajador 				 	= DB::table('tipocontratotrabajadores')->pluck('descripcion','id')->toArray();
		$combotipocontratotrabajador  		 		= array($contrato->tipocontratotrabajador_id => $contrato->tipocontratotrabajador->descripcion) + $tipocontratotrabajador;


		return View::make('trabajador/ajax/editc',
						 [
	        					'id'  	    							=> $id,
	        					'idopcion'  	    					=> $idopcion,
	        					'idtrabajador'  	    				=> $idtrabajador,
	        					'combotipocontratotrabajador'  			=> $combotipocontratotrabajador,
	        					'contrato'  	    					=> $contrato,
						 ]);
	}	
}
