<!DOCTYPE html>
<html>
  <head>
    <title>Servicio Meteorológico</title>
    <meta charset="utf-8">
  </head>
  <body>
  <?php

// Crear una instancia de SoapClient con la URL del WSDL
$wsdl = "http://localhost:55750/Service.svc?wsdl";
$client = new SoapClient($wsdl); // OJO habilitar en el XAMPP la extension=soap en el archivo php.ini

try {
    // Llamar al método del servicio web
    $result = $client->mostrarRegistros();

    // Procesar la respuesta
    $lista = $result->mostrarRegistrosResult->Meteo;

    echo '<h1>Servicio de Meteorología</h1>';

    // Iniciar la tabla
    echo '<table style="border-collapse: collapse; border: 1px solid black; font-size: 16px;">';
    echo '<tr>';
    echo '<th style="border: 1px solid black; padding: 8px;">Provincia</th>';
    echo '<th style="border: 1px solid black; padding: 8px;">Fecha Previsión</th>';
    echo '<th style="border: 1px solid black; padding: 8px;">TempMax</th>';
    echo '<th style="border: 1px solid black; padding: 8px;">TempMin</th>';
    echo '<th style="border: 1px solid black; padding: 8px;">Viento</th>';
    echo '<th style="border: 1px solid black; padding: 8px;">Humedad</th>';
    echo '<th style="border: 1px solid black; padding: 8px;">Precipitaciones</th>';
    echo '<th style="border: 1px solid black; padding: 8px;">Comentarios</th>';
    echo '<th style="border: 1px solid black; padding: 8px;">Valoracion</th>';
    echo '<th style="border: 1px solid black; padding: 8px;">Mapa</th>';
    echo '</tr>';

    foreach ($lista as $meteo) {
        echo '<tr>';
        echo '<td style="border: 1px solid black; padding: 8px;">' . $meteo->Provincia . '</td>';
        echo '<td style="border: 1px solid black; padding: 8px;">' . $meteo->FechaPrevision . '</td>';
        echo '<td style="border: 1px solid black; padding: 8px;">' . $meteo->TempMax . '</td>';
        echo '<td style="border: 1px solid black; padding: 8px;">' . $meteo->TempMin . '</td>';
        echo '<td style="border: 1px solid black; padding: 8px;">' . $meteo->Viento . '</td>';
        echo '<td style="border: 1px solid black; padding: 8px;">' . $meteo->Humedad . '</td>';
        echo '<td style="border: 1px solid black; padding: 8px;">' . $meteo->Precipitaciones . '</td>';
        echo '<td style="border: 1px solid black; padding: 8px;">' . $meteo->Comentarios . '</td>';
        echo '<td style="border: 1px solid black; padding: 8px;">' . $meteo->Valoracion . '</td>';

        echo '<td>';
        //-------------------------IMAGEN---------------------------
        if (isset($meteo->Mapa) && $meteo->Mapa !== null) {
          $imagenBytes = $meteo->Mapa;    // Obtener los datos de bytes de la imagen desde la base de datos
          $imagenBase64 = base64_encode($imagenBytes);  // Convertir los datos de bytes a base64
          echo '<img src="data:image/jpeg;base64,' . $imagenBase64 . '" alt="Imagen de Meteo" style="width: 200px; height: 200px;">'; // Usar la cadena base64 en la etiqueta de imagen HTML y establecer el ancho y alto a 100px
        } else {
          echo 'No hay Mapa disponible'; // Mostrar mensaje si no hay imagen disponible
        }
        //-------------------------IMAGEN---------------------------

        echo '</td>';
        echo '</tr>';
    }

    echo '</table>';
} catch (SoapFault $e) {
    echo "Error: " . $e->getMessage();
}

?>



  </body>
</html>