<label class="col-sm-3 control-label">Área</label>
<div class="col-sm-7">
  {!! Form::select( 'area_id', $comboarea, array(),
                    [
                      'class'       => 'form-control control input-sm' ,
                      'id'          => 'area_id',
                      'required'    => '',
                      'data-aw'     => '11'
                    ]) !!}
</div>