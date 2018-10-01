<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Fichasocioeconomica extends Model
{
    protected $table = 'fichasocioeconomicas';
    public $timestamps=false;

    protected $primaryKey = 'id';
    public $incrementing = false;


    public function tipovivienda()
    {
        return $this->belongsTo('App\Tipovivienda');
    }

    public function casaparte()
    {
        return $this->belongsTo('App\Casaparte');
    }

    public function construccionmaterial()
    {
        return $this->belongsTo('App\Construccionmaterial');
    }

    public function servicio()
    {
        return $this->belongsTo('App\Servicio');
    }

     public function centromedico()
    {
        return $this->belongsTo('App\Centromedico');
    }

    public function frecuenciamedico()
    {
        return $this->belongsTo('App\Frecuenciamedico');
    }

    public function frecuenciaexamen()
    {
        return $this->belongsTo('App\Frecuenciaexamen');
    }

    public function enfermedad()
    {
        return $this->belongsTo('App\Enfermedad');
    }

    public function trabajador()
    {
        return $this->belongsTo('App\Trabajador');
    }


    
}
