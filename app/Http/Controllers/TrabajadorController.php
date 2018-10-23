<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Validation\Rule;
use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Crypt;
use App\Trabajador,App\Estadocivil,App\Empresa,App\Local,App\Cargo;
use View;
use Session;
use Hashids;


class TrabajadorController extends Controller
{
	public function actionFichaTrabajador(Request $request){

		$id 						= strtoupper($request['id']);
		$trabajador     			= Trabajador::where('id', '=', $id)->first();
		$fichasocioeconomica     	= Fichasocioeconomica::where('id', '=', $id)->first();
		
		return View::make('usuario/ajax/datotrabajador',
						 [
						 	'trabajador' 			 => $trabajador,
						 	'fichasocioeconomica' 	 => $fichasocioeconomica
						 ]);
 	}

	public function actionListarTrabajador($idopcion)
	{


		/******************* validar url **********************/
		$validarurl = $this->funciones->getUrl($idopcion,'Ver');
	    if($validarurl <> 'true'){return $validarurl;}
	    /******************************************************/

	    $listatrabajadores = Trabajador::orderBy('id', 'asc')->get();

		return View::make('trabajador/listatrabajadores',
						 [
						 	'listatrabajadores' => $listatrabajadores,
						 	'idopcion' => $idopcion,
						 ]);
	}


	public function actionAgregarTrabajador($idopcion,Request $request)
	{


		/******************* validar url **********************/
		$validarurl = $this->funciones->getUrl($idopcion,'Anadir');
	    if($validarurl <> 'true'){return $validarurl;}
	    /******************************************************/

		if($_POST)
		{


			/**** Validaciones laravel ****/
			$this->validate($request, [
	            'dni' => 'unique:trabajadores',
			], [
            	'dni.unique' => 'DNI ya registrado',
        	]);
			/******************************/

			$idtrabajador 		 				 = $this->funciones->getCreateId('trabajadores');
			
			$cabecera            	 	 		 =	new Trabajador;
			$cabecera->id 	     	 	 		 =  $idtrabajador;
			$cabecera->dni 	     		 		 =  $request['dni'];
			$cabecera->apellidopaterno 	 		 =  $request['apellidopaterno'];
			$cabecera->apellidomaterno 	 		 = 	$request['apellidomaterno'];
			$cabecera->nombres  		 		 =	$request['nombre'];
			$cabecera->telefono  		 		 =	$request['telefono'];
			$cabecera->email  			 		 =	$request['email'];
			$cabecera->tipodocumento_id  		 = 	$request['tipodocumento_id'];
			$cabecera->estadocivil_id 	 		 = 	$request['estadocivil_id'];
			$cabecera->nacionalidad_id   		 = 	$request['nacionalidad_id'];
			$cabecera->pais_id   		 		 = 	$request['pais_id'];
			$cabecera->departamento_id   		 = 	$request['departamento_id'];
			$cabecera->provincia_id   			 = 	$request['provincia_id'];
			$cabecera->distrito_id   			 = 	$request['distrito_id'];
			$cabecera->tipovia_id 		 		 = 	$request['tipovia_id'];
			$cabecera->nombrevia 		 		 =	$request['nombrevia'];
			$cabecera->numerovia 		 		 =	$request['numerovia'];
			$cabecera->interior 		 		 =	$request['numerovia'];
			$cabecera->tipozona_id 	 	 		 = 	$request['tipozona_id'];
			$cabecera->nombrezona		 		 =	$request['nombrezona'];
			$cabecera->referencia		 		 =	$request['referencia'];

			$cabecera->tipotrabajador_id 		 = 	$request['tipotrabajador_id'];

			$cabecera->motivobaja_id 	 		 = 	$request['motivobaja_id'];
			$cabecera->entidadfinanciera_id 	 = 	$request['entidadfinanciera_id'];
			$cabecera->sexo 		 	 		 = 	$request['sexo'];
			$cabecera->discapacidad 			 = 	$request['discapacidad'];
			$cabecera->sindicalizado 			 = 	$request['sindicalizado'];
			$cabecera->regimensalud_id 			 = 	$request['regimensalud_id'];
			$cabecera->regimenpensionario_id	 = 	$request['regimenpensionario_id'];
			$cabecera->cussp  	 				 =	$request['cussp'];
			$cabecera->codigoeps_id 			 = 	$request['codigoeps_id'];
			$cabecera->situacion_id				 = 	$request['situacion_id'];
			$cabecera->afiliadoeps 		 		 = 	$request['afiliadoeps'];
			$cabecera->essaludvida 		 		 = 	$request['essaludvida'];
			$cabecera->senati 		 	 		 = 	$request['senati'];
			$cabecera->sctrsalud 		 		 = 	$request['sctrsalud'];
			$cabecera->sctrpensiones 			 = 	$request['sctrpensiones'];
			$cabecera->domiciliado 		 		 = 	$request['domiciliado'];
			$cabecera->situacioneducativa_id	 = 	$request['situacioneducativa_id'];
			$cabecera->estudiosperu				 = 	$request['estudiosperu'];
			$cabecera->regimeninstitucion_id	 = 	$request['regimeninstitucion_id'];
			$cabecera->tipoinstitucion_id   	 = 	$request['tipoinstitucion_id'];
			$cabecera->institucion_id   		 = 	$request['institucion_id'];
			$cabecera->carrera_id   			 = 	$request['carrera_id'];
			$cabecera->añoegreso 	        	 =  $request['añoegreso'];
			$cabecera->regimenlaboral_id   		 = 	$request['regimenlaboral_id'];
			$cabecera->categoriaocupacional_id   = 	$request['categoriaocupacional_id'];
			$cabecera->ocupacion_id   			 = 	$request['ocupacion_id'];
			$cabecera->local_id 				 = 	$request['local_id'];
			$cabecera->situacionespecial_id		 = 	$request['situacionespecial_id'];
			$cabecera->rentaquinta 		 	 	 = 	$request['rentaquinta'];
			$cabecera->quintaexonerada 		 	 = 	$request['quintaexonerada'];
			$cabecera->asignacionfamiliar 		 = 	$request['asignacionfamiliar'];
			$cabecera->fechanacimiento 			 = 	$request['fechanacimiento'];
			$cabecera->fechainicio 				 = 	$request['fechainicio'];
			$cabecera->fechafin 				 = 	$request['fechafin'];
			$cabecera->template 		 		 = 	'';
			$cabecera->template10 			 	 = 	'';
			$cabecera->mar_huella 			 	 = 	'';
			$cabecera->mar_dni 				 	 = 	'';

			$cabecera->save();
 			return Redirect::to('/gestion-de-trabajador/'.$idopcion)->with('bienhecho', 'Trabajador '.$request['nombre'].' '.$request['apellidopaterno'].' registrado con éxito');



		}else{


			$tipodocumento 				 = DB::table('tipodocumentos')->pluck('descripcion','id')->toArray();
			$combotipodocumento  		 = array('' => "Seleccione Tipo Documento") + $tipodocumento;

			$estadocivil 				 = DB::table('estadocivils')->pluck('nombre','id')->toArray();
			$comboestadocivil  			 = array('' => "Seleccione Estado Civil") + $estadocivil;

			$nacionalidad 				 = DB::table('nacionalidades')->pluck('nombre','id')->toArray();
			$combonacionalidad 			 = array('' => "Seleccione Nacionalidad") + $nacionalidad;

			$pais 				 		 = DB::table('paises')->pluck('nombre','id')->toArray();
			$combopais 			 		 = array('' => "Seleccione Pais") + $pais ;

			$departamento 				 = DB::table('departamentos')->pluck('nombre','id')->toArray();
			$combodepartamento			 = array('' => "Seleccione Departamento") + $departamento;

			$comboprovincia				 = array('' => "Seleccione Provincia");

			$combodistrito				 = array('' => "Seleccione Distrito");

			$tipovia 					 = DB::table('tipovias')->pluck('tipo','id')->toArray();
			$combotipovia				 = array('' => "Seleccione Vía") + $tipovia;

			$tipozona 					 = DB::table('tipozonas')->pluck('descripcion','id')->toArray();
			$combotipozona				 = array('' => "Seleccione Zona") + $tipozona;
		
			$tipotrabajador				 = DB::table('tipotrabajadores')->pluck('descripcionabreviada','id')->toArray();
			$combotipotrabajador		 = array('' => "Seleccione Tipo Trabajador") + $tipotrabajador;

			$motivobaja					 = DB::table('motivobajas')->pluck('descripcionabreviada','id')->toArray();
			$combomotivobaja			 = array('' => "Seleccione Motivo Baja") + $motivobaja;

			$entidadfinanciera 			 = DB::table('entidadfinancieras')->pluck('entidad','id')->toArray();
			$comboentidadfinanciera		 = array('' => "Seleccione Entidad") + $entidadfinanciera;

			$regimensalud 				 = DB::table('regimensaluds')->pluck('descripcionabreviada','id')->toArray();
			$comboregimensalud			 = array('' => "Seleccione Regimen Salud") + $regimensalud;

			$regimenpensionario 		 = DB::table('regimenpensionarios')->pluck('descripcionabreviada','id')->toArray();
			$comboregimenpensionario	 = array('' => "Seleccione Regimen Pensionario") + $regimenpensionario;

			$codigoeps 					 = DB::table('codigoeps')->pluck('descripcion','id')->toArray();
			$combocodigoeps				 = array('' => "Seleccione EPS") + $codigoeps;

			$situacion 					 = DB::table('situaciones')->pluck('descripcionabreviada','id')->toArray();
			$combosituacion				 = array('' => "Seleccione Situación") + $situacion;

			$situacioneducativa			 = DB::table('situacioneducativas')->pluck('descripcionabreviada','id')->toArray();
			$combosituacioneducativa	 = array('' => "Nivel Instrucción") + $situacioneducativa;

			$regimeninstitucion 		 = DB::table('regimeninstituciones')->pluck('nombre','id')->toArray();
			$comboregimeninstitucion	 = array('' => "Seleccione Regimen Institucion") + $regimeninstitucion;

			$combotipoinstitucion		 = array('' => "Seleccione Tipo Insitucion");

			$comboinstitucion			 = array('' => "Seleccione Institucion");

			$combocarrera				 = array('' => "Seleccione Carrera");

			$regimenlaboral 			 = DB::table('regimenlaborales')->pluck('descripcionabreviada','id')->toArray();
			$comboregimenlaboral		 = array('' => "Seleccione Regimen Laboral") + $regimenlaboral;

			$categoriaocupacional 	  	 = DB::table('categoriaocupacionales')->pluck('descripcion','id')->toArray();
			$combocategoriaocupacional	 = array('' => "Seleccione Categoria Ocupacional") + $categoriaocupacional;

			$ocupacion 				  	 = DB::table('ocupaciones')->pluck('descripcion','id')->toArray();
			$comboocupacion 		  	 = array('' => "Seleccione Ocupacion") + $ocupacion;


			$empresa 					 = $this->funciones->getEmpresa();
			$local	 					 = DB::table('locales')->where('empresa_id','=',$empresa->id)->pluck('nombreabreviado','id')->toArray();
			$combolocal 				 = array('' => "Seleccione Local") + $local;

			$situacionespecial			 = DB::table('situacionespeciales')->pluck('descripcionabreviada','id')->toArray();
			$combosituacionespecial		 = array('' => "Seleccione Situación Especial") + $situacionespecial;

			$ffin 						 = $this->fin;

			return View::make('trabajador/agregartrabajador',
						[
							'combotipodocumento' 			=> $combotipodocumento,
						  	'idopcion' 						=> $idopcion,
						  	'comboestadocivil'	    		=> $comboestadocivil,					
						  	'combonacionalidad' 			=> $combonacionalidad,
						  	'combopais' 					=> $combopais,							
						  	'combodepartamento' 			=> $combodepartamento,
						  	'comboprovincia' 				=> $comboprovincia,
						  	'combodistrito' 				=> $combodistrito,
						  	'combotipovia' 					=> $combotipovia,						  
						  	'combotipozona' 				=> $combotipozona,			  	
					  		'combotipotrabajador' 			=> $combotipotrabajador,			 
						  	'combomotivobaja' 				=> $combomotivobaja,						
						  	'comboentidadfinanciera'		=> $comboentidadfinanciera,
						  	'comboregimensalud' 			=> $comboregimensalud,
						  	'comboregimenpensionario' 		=> $comboregimenpensionario,
						  	'combocodigoeps'		    	=> $combocodigoeps,
						  	'combosituacion' 				=> $combosituacion,
						  	'combosituacioneducativa' 		=> $combosituacioneducativa,
						  	'comboregimeninstitucion' 		=> $comboregimeninstitucion,
						  	'combotipoinstitucion' 			=> $combotipoinstitucion,
						  	'comboinstitucion' 				=> $comboinstitucion,
						  	'combocarrera' 					=> $combocarrera,
						  	'comboregimenlaboral' 			=> $comboregimenlaboral,
						  	'combocategoriaocupacional' 	=> $combocategoriaocupacional,
						  	'comboocupacion' 				=> $comboocupacion,
						  	'combolocal'   					=> $combolocal,
						  	'combosituacionespecial'	    => $combosituacionespecial,
						  	'ffin'	  					    => $ffin,						
						]);

		}
	}


	public function actionModificarTrabajador($idopcion,$idtrabajador,Request $request)
	{

		/******************* validar url **********************/
		$validarurl   = $this->funciones->getUrl($idopcion,'Modificar');
	    if($validarurl <> 'true'){return $validarurl;}
	    /******************************************************/

	    $idtrabajador = $this->funciones->decodificar($idtrabajador);

	    $empresa 	  = $this->funciones->getEmpresa();

	    /*$empresa 					 = $this->funciones->getEmpresa();
			$local	 					 = DB::table('locales')->where('empresa_id','=',$empresa->id)->pluck('nombreabreviado','id')->toArray();
			$combolocal 				 = array('' => "Seleccione Local") + $local;*/

		if($_POST)
		{

			/**** Validaciones laravel ****/
			$this->validate($request, [
	            'dni' => 'unique:trabajadores,dni,'.$idtrabajador.',id'
			], [
            	'dni.unique' => 'DNI ya registrado',
        	]);
			/******************************/


			$cargo 								= Cargo::where('id','=',$request['cargo_id'])->first();


			$cabecera            	 	 		  =		Trabajador::find($idtrabajador);
			$empresa            	 	 		  =		Empresa::find($empresa->id);
			$cabecera->dni 	     		 		  =  	$request['dni'];
			$cabecera->apellidopaterno 	 		  =  	$request['apellidopaterno'];
			$cabecera->apellidomaterno 	 		  = 	$request['apellidomaterno'];
			$cabecera->nombres  		 		  =		$request['nombre'];
			$cabecera->sexo 	 		 		  =  	$request['sexo'];
			$cabecera->telefono  		 		  =		$request['telefono'];
			$cabecera->email  			 		  =		$request['email'];
			$cabecera->estadocivil_id 	 		  = 	$request['estadocivil_id'];
			$cabecera->nacionalidad_id 	 		  = 	$request['nacionalidad_id'];
			$cabecera->pais_id 	 		 		  = 	$request['pais_id'];
			$cabecera->departamento_id 	 		  = 	$request['departamento_id'];
			$cabecera->provincia_id 	 		  = 	$request['provincia_id'];
			$cabecera->distrito_id 	 			  = 	$request['distrito_id'];
			$cabecera->tipovia_id 	 	 		  = 	$request['tipovia_id'];
			$cabecera->nombrevia  		 		  =		$request['nombrevia'];
			$cabecera->numerovia  		 		  =		$request['numerovia'];
			$cabecera->interior  		 		  =		$request['interior'];
			$cabecera->nombrezona  		 		  =		$request['nombrezona'];
			$cabecera->referencia  		 		  =		$request['referencia'];

			$cabecera->tipotrabajador_id 		  = 	$request['tipotrabajador_id'];
			
			$cabecera->motivobaja_id 	 		  = 	$request['motivobaja_id'];
			$cabecera->entidadfinanciera_id 	  = 	$request['entidadfinanciera_id'];
			$cabecera->discapacidad 			  = 	$request['discapacidad'];
			$cabecera->sindicalizado 			  = 	$request['sindicalizado'];
			$cabecera->codigoeps_id 			  = 	$request['codigoeps_id'];
			$cabecera->situacion_id				  = 	$request['situacion_id'];
			$cabecera->afiliadoeps 		 		  = 	$request['afiliadoeps'];
			$cabecera->regimensalud_id 			  = 	$request['regimensalud_id'];
			$cabecera->regimenpensionario_id	  = 	$request['regimenpensionario_id'];
			$cabecera->cussp  		 			  =		$request['cussp'];
			$cabecera->essaludvida 		 		  = 	$request['essaludvida'];
			$cabecera->senati 		 	 		  = 	$request['senati'];
			$cabecera->sctrsalud 		 		  = 	$request['sctrsalud'];
			$cabecera->sctrpensiones 			  = 	$request['sctrpensiones'];
			$cabecera->domiciliado 	 			  =  	$request['domiciliado'];
			$cabecera->situacioneducativa_id	  = 	$request['situacioneducativa_id'];
			$cabecera->estudiosperu 			  = 	$request['estudiosperu'];
			$cabecera->activo 	 		 		  =  	$request['activo'];
			$cabecera->añoegreso 	        	  =   	$request['añoegreso'];
			$cabecera->regimenlaboral_id   		  = 	$request['regimenlaboral_id'];
			$cabecera->categoriaocupacional_id    = 	$request['categoriaocupacional_id'];
			$cabecera->ocupacion_id   			  = 	$request['ocupacion_id'];
			$cabecera->local_id  				  = 	$request['local_id'];
			$cabecera->situacionespecial_id		  = 	$request['situacionespecial_id'];
			$cabecera->rentaquinta 		 	 	  = 	$request['rentaquinta'];
			$cabecera->quintaexonerada 		 	  = 	$request['quintaexonerada'];
			$cabecera->asignacionfamiliar 		  = 	$request['asignacionfamiliar'];
			$cabecera->fechanacimiento 			  = 	$request['fechanacimiento'];
			$cabecera->regimeninstitucion_id	  = 	$request['regimeninstitucion_id'];
			$cabecera->tipoinstitucion_id   	  = 	$request['tipoinstitucion_id'];
			$cabecera->institucion_id   		  = 	$request['institucion_id'];
			$cabecera->carrera_id   			  = 	$request['carrera_id'];
			$cabecera->fechainicio 				  = 	$request['fechainicio'];
			$cabecera->fechafin 				  = 	$request['fechafin'];

			$cabecera->save();

 			return Redirect::to('/gestion-de-trabajador/'.$idopcion)->with('bienhecho', 'Trabajador '.$request['nombre'].' '.$request['apellidopaterno'].' modificado con éxito');


		}else{


		        $trabajador 					= Trabajador::where('id', $idtrabajador)->first();


				$tipodocumento 				 	= DB::table('tipodocumentos')->pluck('descripcion','id')->toArray();
				$combotipodocumento  		 	= array($trabajador->tipodocumento_id => $trabajador->tipodocumento->descripcion) + $tipodocumento;

				$estadocivil 					= DB::table('estadocivils')->pluck('nombre','id')->toArray();
				$comboestadocivil  				= array($trabajador->estadocivil_id => $trabajador->estadocivil->nombre) + $estadocivil ;

				$nacionalidad 					= DB::table('nacionalidades')->pluck('nombre','id')->toArray();
				$combonacionalidad  			= array($trabajador->nacionalidad_id => $trabajador->nacionalidad->nombre) + $nacionalidad ;

				$pais 							= DB::table('paises')->pluck('nombre','id')->toArray();
				$combopais 						= array($trabajador->pais_id => $trabajador->pais->nombre) + $pais ;

				$departamento					= DB::table('departamentos')->pluck('nombre','id')->toArray();
				$combodepartamento  			= array($trabajador->departamento_id => $trabajador->departamento->nombre) + $departamento ;

				$provincia						= DB::table('provincias')->where('departamento_id','=',$trabajador->departamento_id)->pluck('nombre','id')->toArray();
				$comboprovincia 				= array($trabajador->provincia_id => $trabajador->provincia->nombre) + $provincia ;

				$distrito						= DB::table('distritos')->where('provincia_id','=',$trabajador->provincia_id)->pluck('nombre','id')->toArray();
				$combodistrito  				= array($trabajador->distrito_id => $trabajador->distrito->nombre) + $distrito ;


				$tipovia						= DB::table('tipovias')->pluck('tipo','id')->toArray();
				$combotipovia  					= array($trabajador->tipovia_id => $trabajador->tipovia->tipo) + $tipovia ;

				
				$tipotrabajador					= DB::table('tipotrabajadores')->pluck('descripcionabreviada','id')->toArray();
				$combotipotrabajador			= array($trabajador->tipotrabajador_id => $trabajador->tipotrabajador ->descripcionabreviada) + $tipotrabajador ;

				
				$motivobaja						= DB::table('motivobajas')->pluck('descripcionabreviada','id')->toArray();
				$combomotivobaja 				= array($trabajador->motivobaja_id => $trabajador->motivobaja ->descripcionabreviada) + $motivobaja ;

				$entidadfinanciera 				= DB::table('entidadfinancieras')->pluck('entidad','id')->toArray();
				$comboentidadfinanciera 		= array($trabajador->entidadfinanciera_id => $trabajador->entidadfinanciera ->entidad) + $entidadfinanciera ;


				$codigoeps 						= DB::table('codigoeps')->pluck('descripcion','id')->toArray();
				$combocodigoeps					= array($trabajador->codigoeps_id => $trabajador->codigoeps ->descripcion) + $codigoeps ;

				$situacion 						= DB::table('situaciones')->pluck('descripcionabreviada','id')->toArray();
				$combosituacion					= array($trabajador->situacion_id => $trabajador->situacion ->descripcionabreviada) + $situacion ;

				$regimensalud 					= DB::table('regimensaluds')->pluck('descripcionabreviada','id')->toArray();
				$comboregimensalud				= array($trabajador->regimensalud_id => $trabajador->regimensalud ->descripcionabreviada) + $regimensalud ;

				$tipozona 					 	= DB::table('tipozonas')->pluck('descripcion','id')->toArray();
				$combotipozona				 	= array($trabajador->tipozona_id => $trabajador->tipozona->descripcion) + $tipozona;

				$regimenpensionario 			= DB::table('regimenpensionarios')->pluck('descripcionabreviada','id')->toArray();
				$comboregimenpensionario		= array($trabajador->regimenpensionario_id => $trabajador->regimenpensionario ->descripcionabreviada) + $regimenpensionario ;


				$situacioneducativa				= DB::table('situacioneducativas')->pluck('descripcionabreviada','id')->toArray();
				$combosituacioneducativa		= array($trabajador->situacioneducativa_id => $trabajador->situacioneducativa ->descripcionabreviada) + $situacioneducativa;

				$regimenlaboral					= DB::table('regimenlaborales')->pluck('descripcion','id')->toArray();
				$comboregimenlaboral			= array($trabajador->regimenlaboral_id => $trabajador->regimenlaboral ->descripcion) + $regimenlaboral;

				$categoriaocupacional 	  		= DB::table('categoriaocupacionales')->pluck('descripcion','id')->toArray();
				$combocategoriaocupacional		= array($trabajador->categoriaocupacional_id => $trabajador->categoriaocupacional ->descripcion) + $categoriaocupacional;

				$ocupacion 				  		= DB::table('ocupaciones')->pluck('descripcion','id')->toArray();
				$comboocupacion       			= array($trabajador->ocupacion_id => $trabajador->ocupacion ->descripcion) + $ocupacion;


				$empresa 					 	= $this->funciones->getEmpresa();

				$local							= DB::table('locales')->where('empresa_id','=',$empresa->id)->pluck('nombreabreviado','id')->toArray();
				$combolocal						= array($trabajador->local_id => $trabajador->local ->nombreabreviado) + $local;

				$situacionespecial 				= DB::table('situacionespeciales')->pluck('descripcionabreviada','id')->toArray();
				$combosituacionespecial			= array($trabajador->situacionespecial_id => $trabajador->situacionespecial ->descripcionabreviada) + $situacionespecial ;

				$regimeninstitucion				= DB::table('regimeninstituciones')->pluck('nombre','id')->toArray();
				$comboregimeninstitucion  		= array($trabajador->regimeninstitucion_id => $trabajador->regimeninstitucion->nombre) + $regimeninstitucion ;

				$tipoinstitucion				= DB::table('tipoinstituciones')->where('regimeninstitucion_id','=',$trabajador->regimeninstitucion_id)->pluck('nombre','id')->toArray();
				$combotipoinstitucion			= array($trabajador->tipoinstitucion_id => $trabajador->tipoinstitucion->nombre) + $tipoinstitucion ;

				$institucion					= DB::table('instituciones')->where('tipoinstitucion_id','=',$trabajador->tipoinstitucion_id)->pluck('nombre','id')->toArray();
				$comboinstitucion  				= array($trabajador->institucion_id => $trabajador->institucion->nombre) + $institucion ;

				$carrera						= DB::table('carreras')->where('institucion_id','=',$trabajador->institucion_id)->pluck('nombre','id')->toArray();
				$combocarrera  					= array($trabajador->carrera_id => $trabajador->carrera->nombre) + $carrera ;

				$ffin 							= $this->fin;



		        return View::make('trabajador/modificartrabajador', 
		        				[
									'combotipodocumento' 			=> $combotipodocumento,	
									'combotipozona' 				=> $combotipozona,	        					
		        					'trabajador'  	    			=> $trabajador,
		        					'idopcion'  	    			=> $idopcion,
		        					'comboestadocivil'  			=> $comboestadocivil,
		        					'combonacionalidad' 			=> $combonacionalidad,
		        					'combopais' 				    => $combopais,
		        					'combodepartamento' 			=> $combodepartamento,
		        					'comboprovincia' 				=> $comboprovincia,
		        					'combodistrito' 				=> $combodistrito,
		        					'combotipovia' 					=> $combotipovia,        					
		        					'combotipotrabajador' 			=> $combotipotrabajador,		        					
		        					'combomotivobaja' 				=> $combomotivobaja,
		        					'comboentidadfinanciera'		=> $comboentidadfinanciera,
		        					'combocodigoeps'				=> $combocodigoeps,
						  			'combosituacion' 				=> $combosituacion,
						  			'comboregimensalud' 			=> $comboregimensalud,
						  			'comboregimenpensionario' 		=> $comboregimenpensionario,
						  			'combosituacioneducativa' 		=> $combosituacioneducativa,
						  			'comboregimenlaboral' 			=> $comboregimenlaboral,
						  			'combocategoriaocupacional' 	=> $combocategoriaocupacional,
						  			'comboocupacion' 				=> $comboocupacion,
						  			'combolocal' 					=> $combolocal,
						  			'combosituacionespecial' 	  	=> $combosituacionespecial,
						  			'comboregimeninstitucion' 	  	=> $comboregimeninstitucion,
						  			'combotipoinstitucion' 		  	=> $combotipoinstitucion,
						  			'comboinstitucion' 			  	=> $comboinstitucion,
						  			'combocarrera' 				  	=> $combocarrera,
						  			'ffin'	  					  	=> $ffin,
						
		        				]);



		}
	}



}
