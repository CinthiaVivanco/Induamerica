<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Validation\Rule;
use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Crypt;
use App\Trabajador, App\Contrato, App\Cargo;
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
			$cabecera->observacion 	 		 	 =  $request['observacion'];
			$cabecera->estado 		 	 		 = 	$request['estado'];
			$cabecera->gerencia_id 		 		 = 	$cargo->unidad->area->gerencia->id;
			$cabecera->area_id 		 		 	 = 	$cargo->unidad->area->id;
			$cabecera->unidad_id 		 		 = 	$cargo->unidad->id;
			$cabecera->cargo_id 		 		 = 	$cargo->id;

			$cabecera->tipocontrato_id 	 		 = 	$request['tipocontrato_id'];
			$cabecera->jornadalaboral_id 		 = 	$request['jornadalaboral_id'];
			$cabecera->tipopago_id 	 	 		 = 	$request['tipopago_id'];
			$cabecera->numerocuenta  			 =	$request['numerocuenta'];
			$cabecera->periodicidad_id   		 = 	$request['periodicidad_id'];
			$cabecera->remuneracion  	 		 =	$request['remuneracion'];

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

			$cargo 								 = Cargo::where('id','=',$request['cargo_id'])->first();

			$idcontrato 		 			 	 = $this->funciones->getCreateId('contratos');
			
			$cabecera            	 	 		 =	new Contrato;
			$cabecera->id 	     	 	 		 =  $idcontrato;
			$cabecera->trabajador_id  		 	 = 	$idtrabajador;
			$cabecera->fechainicio 				 = 	$request['fechainicio'];
			$cabecera->fechafin 				 = 	$request['fechafin'];
			$cabecera->observacion 	 		 	 =  $request['observacion'];
			$cabecera->estado 		 	 		 = 	$request['estado'];
			$cabecera->gerencia_id 		 		 = 	$cargo->unidad->area->gerencia->id;
			$cabecera->area_id 		 		 	 = 	$cargo->unidad->area->id;
			$cabecera->unidad_id 		 		 = 	$cargo->unidad->id;
			$cabecera->cargo_id 		 		 = 	$cargo->id;
			$cabecera->tipocontrato_id 	 		 = 	$request['tipocontrato_id'];
			$cabecera->jornadalaboral_id 		 = 	$request['jornadalaboral_id'];
			$cabecera->tipopago_id 	 	 		 = 	$request['tipopago_id'];
			$cabecera->numerocuenta  			 =	$request['numerocuenta'];
			$cabecera->periodicidad_id   		 = 	$request['periodicidad_id'];
			$cabecera->remuneracion  	 		 =	$request['remuneracion'];


			$cabecera->save();
 			return Redirect::to('/ficha-contrato-trabajador/'.$idopcion.'/'.$idtrabajadorsd)->with('bienhecho', 'Contrato'.$request['nombre'].' '.$request['apellidopaterno'].' registrado con éxito');

		}else{


			$listacontrato 		    		= Contrato::where('trabajador_id','=' , $idtrabajador)->get();

		    $trabajador 					= Trabajador::where('id', $idtrabajador)->first();

			$tipocontrato 					= DB::table('tipocontratos')->pluck('descripcion','id')->toArray();
			$combotipocontrato  			= array('' => "Seleccione Tipo Contrato") + $tipocontrato;

			$cargo					 	 	= DB::table('cargos')->pluck('nombre','id')->toArray();
			$combocargo				 	 	= array('' => "Seleccione Cargo") + $cargo;

			$tipocontrato				 = DB::table('tipocontratos')->pluck('descripcionabreviada','id')->toArray();
			$combotipocontrato			 = array('' => "Seleccione Tipo Contrato") + $tipocontrato;

			$jornadalaboral				 = DB::table('jornadalaborals')->pluck('descripcion','id')->toArray();
			$combojornadalaboral		 = array('' => "Seleccione Jornada Laboral") + $jornadalaboral;

			$tipopago					 = DB::table('tipopagos')->pluck('descripcion','id')->toArray();
			$combotipopago				 = array('' => "Seleccione Tipo Pago") + $tipopago;

			$periodicidad				 = DB::table('periodicidads')->pluck('descripcion','id')->toArray();
			$comboperiodicidad			 = array('' => "Seleccione Periodicidad") + $periodicidad;


	        return View::make('trabajador/contratotrabajador', 
	        				[

	        					'listacontrato'  	    		=> $listacontrato,
	        					'trabajador'  	    			=> $trabajador,
	        					'idopcion'  	    			=> $idopcion,
	        					'combotipocontrato'  			=> $combotipocontrato,
	        					'combocargo'		    		=> $combocargo,
	        					'combojornadalaboral'   		=> $combojornadalaboral,
							  	'combotipopago' 				=> $combotipopago,						
							  	'comboperiodicidad' 			=> $comboperiodicidad,		
	        				]);
	        					
		}
	}

	public function actionContratoAjax(Request $request)
	{

		$id   							= $request['id'];
		$idopcion   					= $request['idopcion'];
		$idtrabajador   				= $request['idtrabajador'];


		$contrato 		    			= Contrato::where('id','=' , $id)->first();

		$tipocontrato 				 	= DB::table('tipocontratos')->pluck('descripcion','id')->toArray();
		$combotipocontrato  		 	= array($contrato->tipocontrato_id => $contrato->tipocontrato->descripcion) + $tipocontrato;


		return View::make('trabajador/ajax/editc',
						 [
	        					'id'  	    							=> $id,
	        					'idopcion'  	    					=> $idopcion,
	        					'idtrabajador'  	    				=> $idtrabajador,
	        					'combotipocontrato'  					=> $combotipocontrato,
	        					'contrato'  	    					=> $contrato,
						 ]);
	}	
}
