<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Tipocontratotrabajador extends Model
{
    protected $table = 'tipocontratotrabajadores';
    public $timestamps=false;

    protected $primaryKey = 'id';
    public $incrementing = false;
    public $keyType = 'string';



    public function trabajador()
    {
        return $this->hasMany('App\Contrato');
    }


}