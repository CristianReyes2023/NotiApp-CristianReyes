# README NOTI-APP CRISTIAN LEONARDO REYES MORENO.

## Creacion del EF Code First SQL.

- ## Creacion del proyecto.
  

  1. [Creacion de la solucion del proyecto](#Creacion-solucion-de-proyecto)

  2. Creacion del proyecto Webapi

  3. Creacion del proyecto Classlib

  4. Agregar proyectos a la solucion

  5. Agregar la relacion entre proyectos

- ### Instalacion de paquetes.
  

  1. Instalacion de paquetes en proyecto webapi

  2. Instalacion de paquetes en proyecto infraestructura

### CORE.

- #### Entities.
  
  - Ejemplo Entity
    
- #### Interfaces
  
  - Ejemplo Interface
    
  - Ejemplo IGenericRepository
    
  - Ejemplo IUnitOfWork
    
  

### INFRASTRUCTURE.

- #### Data
  
  - Configuration
    
    - Ejemplo configuration
      
  - Ejemplo Entidad de Contexto
    
- #### Repositories
  
  - Ejemplo Repository
    
  - Ejemplo GenericRepository
    
- #### UnitOfWork
  
  - Ejemplo UnitOfWork
    

### API.

- #### Controllers
  
  - Ejemplo controllers
    
- #### DTOs
  
  - Ejemplo Dto
    
- #### Extensions
  
  - ApplicationServiceExtension
    
- #### Helpers
  
  - Pager
    
  - Params
    
- #### Profiles
  
  - MappingProfile
    
- #### Conexion a la base de datos
  
  - Ejemplo conexión Db
    
- #### Program.cs
  

### Creacion de Proyecto

##### Creacion solucion de proyecto

```dotnet
 dotnet new sln
```

##### Creacion proyecto WebApi

```dotnet
dotnet new webapi -o FolderDestino
```