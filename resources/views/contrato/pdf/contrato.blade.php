<!DOCTYPE html>

<html lang="es">

<head>
	<title>{{$titulo}}</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<link rel="icon" type="image/x-icon" href="{{ asset('public/favicon.ico') }}"> 
	<link rel="stylesheet" type="text/css" href="{{ asset('public/css/pdf.css') }} "/>


</head>

<body>
    <header>
    		
    </header>
    <section>

        <h3 align="center">CONTRATO INDIVIDUAL DE TRABAJO SUJETO A MODALIDAD POR INCREMENTO DE ACTIVIDAD</h3>

        <article>

            Conste por el presente documento, el Contrato Individual de Trabajo , de Naturaleza Temporal por Incremento de actividad, que celebran conforme al Art. 57° del TUO del D. Ley 728 aprobado por D.S. 003-97-TR Ley de Productividad y Competitividad Labrol, de una parte INDUAMÉRICA SERVICIOS LOGÍSTICOS SAC, con RUC N° 20479729141, y domicilio en CARRETERA PANAMERICANA NORTE KM 775, a la que se le denominará el EMPLEADOR, representada por el Señor Sixto Perales Huancaruna, identificado con DNI N° 16722570; y de otra parte  <font style="text-transform: uppercase;"> <strong>{{$contrato->trabajador->apellidopaterno}} {{$contrato->trabajador->apellidomaterno}},  {{$contrato->trabajador->nombres}}, </strong> </font> al que en lo sucesivo se le designará como EL TRABAJADOR, identificado con DNI N° {{$contrato->trabajador->dni}}, estado civil {{$contrato->trabajador->estadocivil->nombre}}
                 
                   
                 {{$contrato->trabajador->sexo}} 
                 {{$contrato->trabajador->tipovia->tipo}} 
                 {{$contrato->trabajador->nombrevia}} 
                 {{$contrato->trabajador->numerovia}} 
                 {{$contrato->trabajador->nombrezona}} 
                 DISTRITO {{$contrato->trabajador->distrito->nombre}}, 
                 PROVINCIA {{$contrato->trabajador->provincia->nombre}}, 
                 DEPARTAMENTO {{$contrato->trabajador->departamento->nombre}}
                 {{$contrato->cargo->nombre}} 
                 {{$contrato->fechainicio}} 
                 {{$contrato->fechafin}} 


        </article>

    </section>

</body>
</html>