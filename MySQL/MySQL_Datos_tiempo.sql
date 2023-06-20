
-- http://localhost:8080/  
-- username: root  
-- password: tiger


CREATE SCHEMA `Datos_tiempo` ;

CREATE TABLE `Datos_tiempo`.`Estaciones_meteorologicas` (
  `fecha_introduccion` DATETIME NOT NULL,
  `provincia` VARCHAR(20) NOT NULL,
  `fecha_prevision` DATE NOT NULL,
  `temp_max` DECIMAL(5,2) NOT NULL,
  `temp_min` DECIMAL(5,2) NOT NULL,
  `viento` INT NOT NULL,
  `humedad` DECIMAL(5,2) NOT NULL,
  `precipitaciones` INT NOT NULL,
  `comentarios` VARCHAR(255) NULL,
  `valoracion` VARCHAR(45) NULL,
  `img_mapa` LONGBLOB NULL,
  PRIMARY KEY (`provincia`, `fecha_prevision`));
 
 
INSERT INTO `Datos_tiempo`.`Estaciones_meteorologicas` (fecha_introduccion, provincia, fecha_prevision, temp_max, temp_min, viento, humedad, precipitaciones, comentarios, valoracion, img_mapa)
VALUES ('2023-04-03 10:00:00', 'A Coruña', '2023-04-04', 20.50, 10.20, 25, 65.30, 10, 'Día soleado con algunas nubes', 'Bueno', NULL),
	   ('2023-04-03 10:00:00', 'Pontevedra', '2023-04-04', 22.00, 12.00, 30, 60.50, 5, 'Día nublado con posibilidad de lluvia', 'Regular', NULL),
       ('2023-04-03 11:00:00', 'Ourense', '2023-04-04', 17.50, 8.20, 20, 70.80, 15, NULL, 'Bueno', NULL),
       ('2023-04-03 12:00:00', 'Lugo', '2023-04-04', 21.80, 11.30, 30, 20.30, 6, 'Día soleado y caluroso', 'Excelente', NULL);


       
     
     
 /*--------------------Insertar/Actualizar contacto-----------------------*/
USE `Datos_tiempo`;
DROP procedure IF EXISTS `IARegistro`;

DELIMITER $$
USE `Datos_tiempo`$$
CREATE PROCEDURE `IARegistro` (
  IN `operacion` VARCHAR(1),
  IN `Iprovincia` VARCHAR(20),
  IN `Ifecha_prevision` DATE,
  IN `Itemp_max` DECIMAL(5,2),
  IN `Itemp_min` DECIMAL(5,2),
  IN `Iviento` INT,
  IN `Ihumedad` DECIMAL(5,2),
  IN `Iprecipitaciones` INT,
  IN `Icomentarios` VARCHAR(255),
  IN `Ivaloracion` VARCHAR(45),
  IN `Iimagen` LONGBLOB
)
BEGIN
  IF operacion = 'I' THEN      /* Insertar */
    INSERT INTO Estaciones_meteorologicas (fecha_introduccion, provincia, fecha_prevision, temp_max, temp_min, viento, humedad, precipitaciones, comentarios, valoracion, img_mapa)
    VALUES (NOW(), Iprovincia, Ifecha_prevision, Itemp_max, Itemp_min, Iviento, Ihumedad, Iprecipitaciones, Icomentarios, Ivaloracion, Iimagen);
  ELSEIF operacion = 'A' THEN /* Actualizar */
    UPDATE Estaciones_meteorologicas
    SET fecha_introduccion = NOW(), provincia = Iprovincia, fecha_prevision = Ifecha_prevision, temp_max = Itemp_max, temp_min = Itemp_min,
    viento = Iviento, humedad = Ihumedad, precipitaciones = Iprecipitaciones, comentarios = Icomentarios, valoracion = Ivaloracion, img_mapa = Iimagen
    WHERE provincia = Iprovincia AND fecha_prevision = Ifecha_prevision;
  END IF;
END;$$

DELIMITER ;
/*--------------------Insertar/Actualizar contacto-----------------------*/

/*--------------------Seleccionar/Eliminar contacto-----------------------*/
USE `Datos_tiempo`;
DROP procedure IF EXISTS `BERegistro`;
DELIMITER $$
USE `Datos_tiempo`$$
CREATE PROCEDURE `BERegistro`(
	IN `operacion` VARCHAR(1),
    IN `Iprovincia` VARCHAR(20),
    IN `Ifecha_prevision` DATE
    )
BEGIN
    IF operacion = 'S' THEN        /*Seleccionar un Registro*/
		SELECT * FROM Estaciones_meteorologicas WHERE provincia = Iprovincia AND fecha_prevision = Ifecha_prevision;
    ELSEIF operacion = 'E'  THEN       /*Eliminar*/
		DELETE FROM Estaciones_meteorologicas WHERE provincia = Iprovincia AND fecha_prevision = Ifecha_prevision;
    ELSE
		SELECT * FROM Estaciones_meteorologicas;
    END IF;
END;$$

DELIMITER ;

/*--------------------Seleccionar/Eliminar contacto-----------------------*/






