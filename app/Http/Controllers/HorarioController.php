<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Validation\Rule;
use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Crypt;
use App\Semana,App\Trabajador,App\Horario,App\Horariotrabajador,App\Asistenciatrabajador;
use App\Horariotrabajadoresclonado;
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

		$listatrabajadores 		= 	Trabajador::where('id','<>',$this->prefijomaestro.'000000000001')
							 		->orderBy('id', 'asc')
							 		->get();

		$semana            		=   Semana::where('id','=',$idsemana)->first();
		$horario            	=   Horario::where('id','=',$this->prefijomaestro.'000000000001')->first();
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
				$cabecera->rhlu 			= 	$horario->horainicio.' - '.$horario->horafin;

				$cabecera->mah 				= 	0;
				$cabecera->mad    			=  	date('Y-m-d' ,strtotime('+1 day',strtotime($fechainicio)));
				$cabecera->hma 				= 	$horario->id;
				$cabecera->rhma 			= 	$horario->horainicio.' - '.$horario->horafin;

				$cabecera->mih 				= 	0;
				$cabecera->mid    			=  	date('Y-m-d' ,strtotime('+2 day',strtotime($fechainicio)));
				$cabecera->hmi 				= 	$horario->id;
				$cabecera->rhmi 			= 	$horario->horainicio.' - '.$horario->horafin;				

				$cabecera->juh 				= 	0;
				$cabecera->jud    			=  	date('Y-m-d' ,strtotime('+3 day',strtotime($fechainicio)));
				$cabecera->hju 				= 	$horario->id;
				$cabecera->rhju 			= 	$horario->horainicio.' - '.$horario->horafin;					

				$cabecera->vih 				= 	0;
				$cabecera->vid    			=  	date('Y-m-d' ,strtotime('+4 day',strtotime($fechainicio)));
				$cabecera->hvi 				= 	$horario->id;
				$cabecera->rhvi 			= 	$horario->horainicio.' - '.$horario->horafin;					

				$cabecera->sah 				= 	0;
				$cabecera->sad    			=  	date('Y-m-d' ,strtotime('+5 day',strtotime($fechainicio)));
				$cabecera->hsa 				= 	$horario->id;
				$cabecera->rhsa 			= 	$horario->horainicio.' - '.$horario->horafin;				

				$cabecera->doh 				= 	0;
				$cabecera->dod    			=  	date('Y-m-d' ,strtotime('+6 day',strtotime($fechainicio)));
				$cabecera->hdo 				= 	$horario->id;
				$cabecera->rhdo 			= 	$horario->horainicio.' - '.$horario->horafin;					

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
		$hdia 						=  	'h'.$request['atributo']; //hlu.
		$rhdia 						=  	'rh'.$request['atributo']; //rhlu.
		$diacantmarc 				=  	$request['atributo'].'cantmarc'; //lucantmarc.

		$horario            		=   Horario::where('id','=',$horario_id)->first();
		$hora 						= 	$horario->horainicio.' - '.$horario->horafin;



		Horariotrabajador::where('id','=', $idhorariotrabajadores)
						  	->update([
						  				$hdia 	=> $horario_id,
						  				$rhdia 	=> $hora
						  		  ]);

		Asistenciatrabajador::where('horariotrabajador_id','=', $idhorariotrabajadores)
							->update([
										$hdia => $horario_id,
										$diacantmarc => $horario->marcacion
									]);



		$response[] = array(
							'error'           		=> true,
							'hora'      			=> $hora
		);

		echo json_encode($response);

	}


	public function actionAjaxClonarHorario(Request $request)
	{



		$idsemana 				=  	$request['idsemana'];
		$idsemana 				= 	$this->funciones->decodificar($idsemana);		

		Horariotrabajadoresclonado::where('activo','=','1')->delete();

		$horariotrabajador 		= 	Horariotrabajador::all('id','luh','lud','hlu','rhlu','mah','mad','hma','rhma',
											'mih','mid','hmi','rhmi','juh','jud','hju','rhju',
											'vih','vid','hvi','rhvi','sah','sad','hsa','rhsa',
											'doh','dod','hdo','rhdo','activo','trabajador_id','semana_id')
									->where('semana_id','=',$idsemana)
									->toArray();

		DB::table('horariotrabajadoresclonados')->insert($horariotrabajador);

		$response[] = array(
							'error'           		=> true
		);

		echo json_encode($response);



	}


	public function actionAjaxCopiarHorarioClonado(Request $request)
	{


		$idsemana 					=  	$request['idsemana'];
		$idsemana 					= 	$this->funciones->decodificar($idsemana);		
		$listahorario 				= 	Horariotrabajador::where('semana_id','=',$idsemana)->orderBy('id', 'asc')->get();


		foreach($listahorario as $item){


			$listahorarioclonado 		= 	Horariotrabajadoresclonado::where('trabajador_id','=', $item->trabajador_id)->first();


			if(count($listahorarioclonado)>0){


				/************** HORARIO DEL TRABAJADOR ******************/

				$cabecera            	 	=	Horariotrabajador::find($item->id);

				$cabecera->luh 				= 	$listahorarioclonado->luh;
				$cabecera->hlu 				= 	$listahorarioclonado->hlu;
				$cabecera->rhlu 			= 	$listahorarioclonado->rhlu;

				$cabecera->mah 				= 	$listahorarioclonado->mah;
				$cabecera->hma 				= 	$listahorarioclonado->hma;
				$cabecera->rhma 			= 	$listahorarioclonado->rhma;

				$cabecera->mih 				= 	$listahorarioclonado->mih;
				$cabecera->hmi 				= 	$listahorarioclonado->hmi;
				$cabecera->rhmi 			= 	$listahorarioclonado->rhmi;	

				$cabecera->juh 				= 	$listahorarioclonado->juh;
				$cabecera->hju 				= 	$listahorarioclonado->hju;
				$cabecera->rhju 			= 	$listahorarioclonado->rhju;					

				$cabecera->vih 				= 	$listahorarioclonado->vih;
				$cabecera->hvi 				= 	$listahorarioclonado->hvi;
				$cabecera->rhvi 			= 	$listahorarioclonado->rhvi;					

				$cabecera->sah 				= 	$listahorarioclonado->sah;
				$cabecera->hsa 				= 	$listahorarioclonado->hsa;
				$cabecera->rhsa 			= 	$listahorarioclonado->rhsa;

				$cabecera->doh 				= 	$listahorarioclonado->doh;
				$cabecera->hdo 				= 	$listahorarioclonado->hdo;
				$cabecera->rhdo 			= 	$listahorarioclonado->rhdo;					
				$cabecera->save();



				/************** ASISTENCIA HORARIO DEL TRABAJADOR ******************/

				$cabeceras            		= 	Asistenciatrabajador::where('horariotrabajador_id', $item->id)->first();

				$horario            		=   Horario::where('id','=',$listahorarioclonado->hlu)->first();
			    $cabeceras->hlu 			=  	$horario->id; 
			    $cabeceras->lucantmarc 		=  	$horario->marcacion;

			    $horario            		=   Horario::where('id','=',$listahorarioclonado->hma)->first();
			    $cabeceras->hma 			=  	$horario->id;
			    $cabeceras->macantmarc 		=  	$horario->marcacion;

				$horario            		=   Horario::where('id','=',$listahorarioclonado->hmi)->first();
			    $cabeceras->hmi 			=  	$horario->id;
			    $cabeceras->micantmarc 		=  	$horario->marcacion;

				$horario            		=   Horario::where('id','=',$listahorarioclonado->hju)->first();
			    $cabeceras->hju 			=  	$horario->id;
			    $cabeceras->jucantmarc 		=  	$horario->marcacion;

				$horario            		=   Horario::where('id','=',$listahorarioclonado->hvi)->first();
			    $cabeceras->hvi 			=  	$horario->id;
			    $cabeceras->vicantmarc 		=  	$horario->marcacion;

				$horario            		=   Horario::where('id','=',$listahorarioclonado->hsa)->first();
			    $cabeceras->hsa 			=  	$horario->id;
			    $cabeceras->sacantmarc 		=  	$horario->marcacion;

				$horario            		=   Horario::where('id','=',$listahorarioclonado->hdo)->first();
			    $cabeceras->hdo 			=  	$horario->id;
			    $cabeceras->docantmarc 		=  	$horario->marcacion;	
				$cabeceras->save();	

			}
		}


		/*********** ACTUALIZAR EL AJAX DEL HORARIO ********/
		$horario 		= DB::table('horarios')->pluck('nombre','id')->toArray();
		$combohorario  	= $horario;

		$listahorario 	= Horariotrabajador::where('semana_id','=',$idsemana)->get();

		return View::make('horario/ajax/listahorariopersonal',
						 [
							 'listahorario'   => $listahorario,
							 'combohorario'   => $combohorario
						 ]);

	}









}
