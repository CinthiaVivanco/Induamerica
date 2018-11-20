@if (count($trabajador)>0) 

	@if (count($usuario)<=0) 

		<div class="form-group">
			<label class="col-sm-3 control-label">Nombre</label>
			<div class="col-sm-5">

			  <input  type="text"
			          id="nombre" name='nombre' value='{{$trabajador->nombres}}'  placeholder="Nombre del Trabajador"
			          required = "" disabled="disabled"
			          autocomplete="off" class="form-control input-sm" data-aw="1"/>

			</div>

			<input  type="hidden"
			          id="trabajador_id" name='trabajador_id' value = '{{$trabajador->id}}'/>
		</div> 

		<div class="form-group">
			<label class="col-sm-3 control-label">Apellido Paterno</label>
			<div class="col-sm-5">

			  <input  type="text"
			          id="apellidopaterno" name='apellidopaterno' value='{{$trabajador->apellidopaterno}}'  placeholder="Apellido del Trabajador"
			          required = "" disabled="disabled"
			          autocomplete="off" class="form-control input-sm" data-aw="1"/>

			</div>

			<input  type="hidden"
			          id="trabajador_id" name='trabajador_id' value = '{{$trabajador->id}}'/>
		</div> 

		<div class="form-group">
			<label class="col-sm-3 control-label">Apellido Materno</label>
			<div class="col-sm-5">

			  <input  type="text"
			          id="apellidomaterno" name='apellidomaterno' value='{{$trabajador->apellidomaterno}}'  placeholder="Apellido del Trabajador"
			          required = "" disabled="disabled"
			          autocomplete="off" class="form-control input-sm" data-aw="1"/>

			</div>

			<input  type="hidden"
			          id="trabajador_id" name='trabajador_id' value = '{{$trabajador->id}}'/>
		</div> 

	@else

		<div class="form-group">
			<label class="col-sm-3 control-label">Nombre</label>
			<div class="col-sm-5">

			  <input  type="text"
			          id="nombre" name='nombre'  placeholder="Nombre del Trabajador"
			          required = "" disabled="disabled"
			          autocomplete="off" class="form-control input-sm" data-aw="1"/>

			</div>

			<input  type="hidden"
			          id="trabajador_id" name='trabajador_id'/>

	       
		</div> 

		<div class="form-group">
			<label class="col-sm-3 control-label">Apellido Paterno</label>
			<div class="col-sm-5">

			  <input  type="text"
			          id="apellidopaterno" name='apellidopaterno' value='{{$trabajador->apellidopaterno}}' placeholder="Apellido del Trabajador"
			          required = "" disabled="disabled"
			          autocomplete="off" class="form-control input-sm" data-aw="1"/>

			</div>

			<input  type="hidden"
			          id="trabajador_id" name='trabajador_id' value = '{{$trabajador->id}}'/>
		</div> 

		<div class="form-group">
			<label class="col-sm-3 control-label">Apellido Materno</label>
			<div class="col-sm-5">

			  <input  type="text"
			          id="apellidomaterno" name='apellidomaterno' value='{{$trabajador->apellidomaterno}}' placeholder="Apellido del Trabajador"
			          required = "" disabled="disabled"
			          autocomplete="off" class="form-control input-sm" data-aw="1"/>

			</div>

			<input  type="hidden"
			          id="trabajador_id" name='trabajador_id' value = '{{$trabajador->id}}'/>
		</div> 

		@include('error.erroresajax', ['error' => 'Trabajador '.$trabajador->nombres.' '.$trabajador->apellidopaterno.' '. $trabajador->apellidomaterno.'  ya tiene usuario']) 

	@endif



@else 

	<div class="form-group">
		<label class="col-sm-3 control-label">Nombre</label>
		<div class="col-sm-5">

		  <input  type="text"
		          id="nombre" name='nombre'  placeholder="Nombre del Trabajador"
		          required = "" disabled="disabled"
		          autocomplete="off" class="form-control input-sm" data-aw="1"/>

		</div>

		<input  type="hidden"
		          id="trabajador_id" name='trabajador_id'/>

       
	</div> 


    @include('error.erroresajax', ['error' => 'Trabajador no existe']) 

@endif

