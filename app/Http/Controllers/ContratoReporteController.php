<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Validation\Rule;
use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Crypt;
use App\Contrato,App\Trabajador;
use View;
use Session;
use Hashids;
use PDF;


class ContratoReporteController extends Controller
{

	public function actionContratoPdf($idcontrato)
	{

		$idcontrato 		= 	$this->funciones->decodificar($idcontrato);
		$contrato 			= 	Contrato::where('id','=',$idcontrato)->first();
		$titulo				= 	"Contrato de personal";


		$pdf 			= 	PDF::loadView('contrato.pdf.contrato', 
											[ 
												'contrato' 		  	  => $contrato,
												'titulo' 		  	  => $titulo,												
											]);


		return $pdf->stream('download.pdf');



	}


}
