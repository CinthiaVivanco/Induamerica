  <label class="col-sm-3 control-label">Distrito<span class="required">*</span></label>
  <div class="col-sm-7">
    {!! Form::select( 'distrito_id', $combodistrito, array(),
                      [
                        'class'       => 'form-control control input-sm' ,
                        'id'          => 'distrito_id',
                        'required'    => '',
                        'data-aw'     => '12'
                      ]) !!}
  </div>