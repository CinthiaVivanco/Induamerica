<label class="col-sm-3 control-label">Unidad <span class="required">*</span></label>
<div class="col-sm-7">
  {!! Form::select( 'unidad_id', $combounidad, array(),
                    [
                      'class'       => 'form-control control input-sm' ,
                      'id'          => 'unidad_id',
                      'required'    => '',
                      'data-aw'     => '18'
                    ]) !!}
</div>