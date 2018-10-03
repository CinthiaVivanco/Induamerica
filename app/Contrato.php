<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Contrato extends Model
{
    protected $table = 'contratos';
    public $timestamps=false;

    protected $primaryKey = 'id';
    public $incrementing = false;


    public function tipocontratotrabajador()
    {
        return $this->belongsTo('App\Tipocontratotrabajador');
    }

    public function trabajador()
    {
        return $this->belongsTo('App\Trabajador');
    }


    
}
