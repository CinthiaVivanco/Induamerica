<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Validation\Rule;
use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Crypt;
use View;
use Session;
use Hashids;


class GeneralAjaxController extends Controller
{
	public function actionProvinciaAjax(Request $request)
	{
		$departamento_id   = $request['departamentos_id'];

		$provincia = DB::table('provincias')->where('departamento_id','=',$departamento_id)->pluck('nombre','id')->toArray();
		$comboprovincia  = array(0 => "Seleccione Provincia") + $provincia;

		return View::make('general/ajax/comboprovincia',
						 [
						 'comboprovincia' => $comboprovincia
						
						 ]);
	}	


	public function actionDistritoAjax(Request $request)
	{
		$provincia_id   = $request['provincia_id'];

		$distrito = DB::table('distritos')->where('provincia_id','=',$provincia_id)->pluck('nombre','id')->toArray();
		$combodistrito  = array(0 => "Seleccione Distrito") + $distrito;

		return View::make('general/ajax/combodistrito',
						 [
						 'combodistrito' => $combodistrito

						 ]);
	}	




	public function actionTipoDocumentoAcreditaAjax(Request $request)
	{
		$vinculofamiliar_id   = $request['vinculofamiliar_id'];

		$tipodocumentoacredita = DB::table('tipodocumentoacreditas')->where('vinculofamiliar_id','=',$vinculofamiliar_id)->pluck('descripcionabreviado','id')->toArray();
		$combotipodocumentoacredita  = array(0 => "Seleccione Tipo Doc Acredita") + $tipodocumentoacredita;

		return View::make('general/ajax/combotipodocumentoacredita',
						 [
						 'combotipodocumentoacredita' => $combotipodocumentoacredita

						 ]);
	}		


	public function actionTipoInstitucionAjax(Request $request)
	{
		$regimeninstitucion_id   = $request['regimeninstitucion_id'];

		$tipoinstitucion = DB::table('tipoinstituciones')->where('regimeninstitucion_id','=',$regimeninstitucion_id)->pluck('nombre','id')->toArray();
		$combotipoinstitucion  = array(0 => "Seleccione Tipo Institucion") + $tipoinstitucion;

		return View::make('general/ajax/combotipoinstitucion',
						 [
						 'combotipoinstitucion' => $combotipoinstitucion
						 ]);
	}	


	public function actionInstitucionAjax(Request $request)
	{
		$tipoinstitucion_id   = $request['tipoinstitucion_id'];

		$institucion = DB::table('instituciones')->where('tipoinstitucion_id','=',$tipoinstitucion_id)->pluck('nombre','id')->toArray();
		$comboinstitucion = array(0 => "Seleccione Institucion") + $institucion;

		return View::make('general/ajax/comboinstitucion',
						 [
						 'comboinstitucion' => $comboinstitucion
						 ]);
	}


	public function actionCarreraAjax(Request $request)
	{
		$institucion_id = $request['institucion_id'];

		$carrera 		= DB::table('carreras')->where('institucion_id','=',$institucion_id)->pluck('nombre','id')->toArray();
		$combocarrera   = array(0 => "Seleccione Carrera") + $carrera;

		return View::make('general/ajax/combocarrera',
						 [
						 'combocarrera' => $combocarrera
						 ]);
	}	
}
