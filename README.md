# Nutrielemetal
Proyecto colaborativo del Equipo ElementSoft (mision Tic 2022)

----------------------- Inicio ---------------------------------------

26/septiembre/2021

Listo--------------------------------------
Se crearon las capas de Dominio, persistencia y Servicios ademas de implemento las entidades.

pendiente------------------------------------
Antes de crear los repositorios y el context se debe consultar con el equipo la revision de los cambios

01/octubre/2021

listo 
-cambio en paciente String para cedula y el Id para identificar el registro
-instalacion de todas las librerias del entity framework
-creacion de una clase para los antecedentes (error al momento de crear el mapeo no admite datos primitivos)

pendiente
-el equipo clone y cree la migracion de la BD
-----/comando que no saca error/-------------------------------------
dotnet ef database update --startup-project ..\NutriElemental.App.Consola\