<?php
namespace App\Biblioteca;

use DB,Hashids,Session,Redirect,table;
use App\RolOpcion,App\Local,App\Empresa;

class Funcion{

	public function getUrl($idopcion,$acion) {

	  	//decodificar variable
	  	$decidopcion = Hashids::decode($idopcion);
	  	//ver si viene con letras la cadena codificada
	  	if(count($decidopcion)==0){ 
	  		return Redirect::back()->withInput()->with('errorurl', 'Indices de la url con errores'); 
	  	}

	  	//concatenar con ceros
	  	$idopcioncompleta = str_pad($decidopcion[0], 12, "0", STR_PAD_LEFT); 
	  	//concatenar prefijo

		$prefijo = Local::where('activo', '=', 1)->first();

		$idopcioncompleta = $prefijo->prefijoLocal.$idopcioncompleta;

	  	// ver si la opcion existe
	  	$opcion =  RolOpcion::where('opcion_id', '=',$idopcioncompleta)
	  			   ->where('rol_id', '=',Session::get('usuario')->rol_id)
	  			   ->where($acion, '=',1)
	  			   ->first();


	  	if(count($opcion)<=0){
	  		return Redirect::back()->withInput()->with('errorurl', 'No tiene autorización para '.$acion.' aquí');
	  	}
	  	return 'true';

	  }

	public function decodificar($id) {

	  	//decodificar variable
	  	$iddeco = Hashids::decode($id);
	  	//ver si viene con letras la cadena codificada
	  	if(count($iddeco)==0){ 
	  		return ''; 
	  	}

	  	//concatenar con ceros
	  	$idopcioncompleta = str_pad($iddeco[0], 12, "0", STR_PAD_LEFT); 
	  	//concatenar prefijo

		$prefijo = Local::where('activo', '=', 1)->first();

		$idopcioncompleta = $prefijo->prefijoLocal.$idopcioncompleta;


	  	
	  	return $idopcioncompleta;

	}


	public function getCreateId($tabla) {

  		$id="";


  		// maximo valor de la tabla referente
		$id = DB::table($tabla)
        ->select(DB::raw('max(SUBSTRING(id,9,12)) as id'))
        ->get();

        //conversion a string y suma uno para el siguiente id
        $idsuma = (int)$id[0]->id + 1;

	  	//concatenar con ceros
	  	$idopcioncompleta = str_pad($idsuma, 12, "0", STR_PAD_LEFT); 
	  	//concatenar prefijo
		$prefijo = Local::where('activo', '=', 1)->first()->prefijoLocal;

		$idopcioncompleta = $prefijo.$idopcioncompleta;

  		return $idopcioncompleta;	


	}

	public function getEmpresa() {

		$empresa 	= Empresa::where('activo','=', 1)->first();
  		return $empresa;	


	}


}

