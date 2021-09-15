GO 
USE DBGSS

GO

select * from CARRO LEFT JOIN ALQUILER ON CARRO.ID = ALQUILER.carroId 
WHERE  CARRO.ID = 1 AND ALQUILER.FECHA >= '2011/02/25'


GO
select ALQUILER.SALDO from CARRO LEFT JOIN ALQUILER ON CARRO.ID = ALQUILER.carroId
WHERE  CARRO.ID = 1 AND ALQUILER.FECHA = '2019/02/02'


GO

select CLIENTE.CEDULA, CLIENTE.NOMBRE, ALQUILER.FECHA, ALQUILER.TIEMPO, ALQUILER.SALDO, CARRO.PLACA, CARRO.MARCA
from CLIENTE LEFT JOIN ALQUILER ON ALQUILER.clienteId = CLIENTE.ID LEFT JOIN CARRO ON CARRO.ID = ALQUILER.carroId 

GO

SELECT CLIENTE.* FROM CLIENTE LEFT JOIN ALQUILER 
ON ALQUILER.FECHA >= '2010/02/25' AND ALQUILER.FECHA <= '2030/02/25' AND ALQUILER.clienteId = CLIENTE.ID 
WHERE ALQUILER.clienteId IS NULL

GO

SELECT ALQUILER.FECHA FECHA_ALQUILER, COUNT(PAGOS.alquilerId) TOTAL_PAGOS, SUM(PAGOS.VALOR) TOTAL_PAGADO, MAX(PAGOS.VALOR) MAXIMO_VALOR 
FROM ALQUILER INNER JOIN  PAGOS ON  ALQUILER.ID = PAGOS.alquilerId 
GROUP BY ALQUILER.FECHA

GO

SELECT CARRO.ID COD_CARRO, CARRO.MODELO, CARRO.MARCA, CARRO.COSTO, COUNT(ALQUILER.carroId) TOTAL_ALQUILERES, SUM(ALQUILER.VALORTOTAL) TOTAL_ALQUILERES
FROM CARRO INNER JOIN  ALQUILER ON  CARRO.ID = ALQUILER.carroId
GROUP BY CARRO.ID, CARRO.MODELO, CARRO.MARCA, CARRO.COSTO

GO

SELECT CLIENTE.ID, CLIENTE.NOMBRE, MIN(ALQUILER.FECHA) PRIMER_ALQUILER
FROM CLIENTE INNER JOIN  ALQUILER ON  CLIENTE.ID = ALQUILER.carroId
GROUP BY CLIENTE.ID, CLIENTE.NOMBRE