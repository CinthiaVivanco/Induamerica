<label class="col-sm-3 control-label">Tipo Doc Acredita</label>
<div class="col-sm-8">
  {!! Form::select( 'tipodocumentoacredita_id', $combotipodocumentoacredita, array(),
                    [
                      'class'       => 'form-control control input-sm' ,
                      'id'          => 'tipodocumentoacredita_id',
                      'required'    => '',
                      'data-aw'     => '11'
                    ]) !!}
</div>