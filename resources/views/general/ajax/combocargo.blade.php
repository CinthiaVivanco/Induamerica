  <label class="col-sm-3 control-label">Cargo <span class="required">*</span></label>
  <div class="col-sm-7">
    {!! Form::select( 'cargo_id', $combocargo, array(),
                      [
                        'class'       => 'form-control control input-sm' ,
                        'id'          => 'cargo_id',
                        'required'    => '',
                        'data-aw'     => '12'
                      ]) !!}
  </div>