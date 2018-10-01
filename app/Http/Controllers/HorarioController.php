<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Validation\Rule;
use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Crypt;
use App\Semana,App\Trabajador,App\Horario,App\Horariotrabajador,App\Asistenciatrabajador;
use View;
use Session;
use Hashids;


class HorarioController extends Controller
{

	public function actionListarSemanas($idopcion)
	{

		/******************* validar url **********************/
		$validarurl = $this->funciones->getUrl($idopcion,'Ver');
	    if($validarurl <> 'true'){return $validarurl;}
	    /******************************************************/

	    $listasemana 	= Semana::orderBy('numero', 'asc')->get();
	    $hoy 			= date_format(date_create($this->fin), 'Y-m-d');

		return View::make('horario/listasemanas',
						 [
						 	'listasemana' 	=> $listasemana,
						 	'idopcion' 		=> $idopcion,
						 	'hoy' 	   		=> $hoy,
						 ]);


	}




	public function actionAjaxListarHorario(Request $request)
	{


		$idsemana 				=  	$request['idsemana'];
		$idsemana 				= 	$this->funciones->decodificar($idsemana);

		$listatrabajadores 		= 	Trabajador::where('id','<>','CHI01CEN000000000001')
							 		->orderBy('id', 'asc')
							 		->get();

		$semana            		=   Semana::where('id','=',$idsemana)->first();
		$horario            	=   Horario::where('id','=','CHI01CEN000000000001')->first();
		$fechainicio 			= 	$semana->fechainicio;


		$horariotrabajador 		= 	Horariotrabajador::where('semana_id','=',$idsemana)->first();


		if(count($horariotrabajador)<=0){

			foreach($listatrabajadores as $item){


				$idhorariotrabajador 		= 	$this->funciones->getCreateId('horariotrabajadores');
				$idasistenciatrabajadores 	= 	$this->funciones->getCreateId('asistenciatrabajadores');

			    $cabecera            		=	new Horariotrabajador;
			    $cabecera->id 	    		=  	$idhorariotrabajador;
				$cabecera->luh 				= 	0;
				$cabecera->lud    			=  	$fechainicio;
				$cabecera->hlu 				= 	$horario->id;

				$cabecera->mah 				= 	0;
				$cabecera->mad    			=  	date('Y-m-d' ,strtotime('+1 day',strtotime($fechainicio)));
				$cabecera->hma 				= 	$horario->id;

				$cabecera->mih 				= 	0;
				$cabecera->mid    			=  	date('Y-m-d' ,strtotime('+2 day',strtotime($fechainicio)));
				$cabecera->hmi 				= 	$horario->id;

				$cabecera->juh 				= 	0;
				$cabecera->jud    			=  	date('Y-m-d' ,strtotime('+3 day',strtotime($fechainicio)));
				$cabecera->hju 				= 	$horario->id;

				$cabecera->vih 				= 	0;
				$cabecera->vid    			=  	date('Y-m-d' ,strtotime('+4 day',strtotime($fechainicio)));
				$cabecera->hvi 				= 	$horario->id;

				$cabecera->sah 				= 	0;
				$cabecera->sad    			=  	date('Y-m-d' ,strtotime('+5 day',strtotime($fechainicio)));
				$cabecera->hsa 				= 	$horario->id;

				$cabecera->doh 				= 	0;
				$cabecera->dod    			=  	date('Y-m-d' ,strtotime('+6 day',strtotime($fechainicio)));
				$cabecera->hdo 				= 	$horario->id;

			    $cabecera->trabajador_id 	=  	$item->id;
			    $cabecera->semana_id 		=  	$idsemana;
				$cabecera->save();



			    $cabecera            				=	new Asistenciatrabajador;
			    $cabecera->id 	    				=  	$idasistenciatrabajadores;
				$cabecera->lud    					=  	$fechainicio;
			    $cabecera->hlu 						=  	$horario->id;
			    $cabecera->lucantmarc 				=  	$horario->marcacion;			    

				$cabecera->mad    					=  	date('Y-m-d' ,strtotime('+1 day',strtotime($fechainicio)));
			    $cabecera->hma 						=  	$horario->id;
			    $cabecera->macantmarc 				=  	$horario->marcacion;

				$cabecera->mid    					=  	date('Y-m-d' ,strtotime('+2 day',strtotime($fechainicio)));
			    $cabecera->hmi 						=  	$horario->id;
			    $cabecera->micantmarc 				=  	$horario->marcacion;

				$cabecera->jud    					=  	date('Y-m-d' ,strtotime('+3 day',strtotime($fechainicio)));
			    $cabecera->hju 						=  	$horario->id;
			    $cabecera->jucantmarc 				=  	$horario->marcacion;

				$cabecera->vid    					=  	date('Y-m-d' ,strtotime('+4 day',strtotime($fechainicio)));
			    $cabecera->hvi 						=  	$horario->id;
			    $cabecera->vicantmarc 				=  	$horario->marcacion;

				$cabecera->sad    					=  	date('Y-m-d' ,strtotime('+5 day',strtotime($fechainicio)));
			    $cabecera->hsa 						=  	$horario->id;
			    $cabecera->sacantmarc 				=  	$horario->marcacion;

				$cabecera->dod    					=  	date('Y-m-d' ,strtotime('+6 day',strtotime($fechainicio)));
			    $cabecera->hdo 						=  	$horario->id;
			    $cabecera->docantmarc 				=  	$horario->marcacion;		

			    $cabecera->trabajador_id 			=  	$item->id;
			    $cabecera->semana_id 				=  	$idsemana;
			    $cabecera->horariotrabajador_id 	=  	$idhorariotrabajador;
				$cabecera->save();


			}
		}

		$horario 		= DB::table('horarios')->pluck('nombre','id')->toArray();
		$combohorario  	= $horario;

		$listahorario 	= Horariotrabajador::where('semana_id','=',$idsemana)->get();

		return View::make('horario/ajax/listahorariopersonal',
						 [
							 'listahorario'   => $listahorario,
							 'combohorario'   => $combohorario
						 ]);

	}

	public function actionAjaxActivarHorarioTrabajador(Request $request)
	{



		$idhorariotrabajadores 		=  	$request['name'];
		$idhorariotrabajadores 		= 	$this->funciones->decodificar($idhorariotrabajadores);
		Horariotrabajador::where('id','=', $idhorariotrabajadores)->update([$request['accion'] => $request['check']]);
	
		echo("1");

	}


	public function actionAjaxSelectHorarioTrabajador(Request $request)
	{

		$idhorariotrabajadores 		=  	$request['idhorariotrabajador'];
		$idhorariotrabajadores 		= 	$this->funciones->decodificar($idhorariotrabajadores);
		$horario_id 				=  	$request['horario_id'];

		Horariotrabajador::where('id','=', $idhorariotrabajadores)->update(['horario_id' => $horario_id]);
		Asistenciatrabajador::where('horariotrabajador_id','=', $idhorariotrabajadores)->update(['horario_id' => $horario_id]);

		echo("1");

	}




}
