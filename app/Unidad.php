<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Unidad extends Model
{
    protected $table = 'unidades';
    public $timestamps=false;

    protected $primaryKey = 'id';
    public $incrementing = false;
    public $keyType = 'string';

    
    public function trabajador()
    {
        return $this->hasMany('App\Trabajador');
    }

    public function cargo()
    {
        return $this->hasMany('App\Cargo');
    }   


    public function area()
    {
        return $this->belongsTo('App\Area');
    }

}
