# agencia-api-rest

## Instalacion

```docker-compose build```
Luego
```docker-compose up``` 
se publica en el puerto local 3000 si lo desea cabiar modificar el docker compose file en  la etiqueta ports

## Documentación de la API
http://localhost:3000/swagger

## Base de datos
dbscripts/seed.sql Se encuentra el script para la creación de la base de datos.
El docker-compose ejecuta ese script  y levanta la imagen de postgres en otro puerto distinto al 5432.

Las credenciales tambien se encuentran en el docker-compose, las cuáles están por defecto:
username: admin,
password: 123,
databasename: inventario

## Entrar al contenedor de postgres:
docker exec -it nombre_imagen_postgres bash
Depués insetar la crendenciales en esl siquiente comando:
psql -U username -W  “password” -d databasename

### nota: 
verificar que se esté ejecutando el contenedor es decir ya haber ejecutado docker-compose up
use: docker ps 
