<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Formato extends Model
{
    protected $table = 'formatos';
    public $timestamps=false;

    protected $primaryKey = 'id';
    public $incrementing = false;
    public $keyType = 'string';


    public function contrato()
    {
        return $this->hasMany('App\Contrato');
    }
    

}