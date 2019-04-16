// ENGLISH: 
// 
// Why Onion Architecture

//There are several traditional architectures, like 3-tier architecture and n-tier architecture, all having their own pros and cons. 
//All these traditional architectures have some fundamental issues, such as - tight coupling and separation of concerns. 
//The Model-View-Controller is the most commonly used web application architecture, these days. It solves the problem of 
//separation of concern as there is a separation between UI, business logic, and data access logic. The View is used to design 
//the user interface. The Model is used to pass the data between View and Controller on which the business logic performs any 
//operations. The Controller is used to handle the web request by action methods and returns View accordingly. Hence, it solves 
//the problem of separation of concern while the Controller is still used to database access logic. In essence, MVC solves the 
//separation of concern issue but the tight coupling issue still remains.
//On the other hand, Onion Architecture addresses both the separation of concern and tight coupling issues. The overall philosophy 
//of the Onion Architecture is to keep the business logic, data access logic, and model in the middle of the application 
//and push the dependencies as far outward as possible means all coupling towards to center.
//
// It is the center part of the architecture. It holds all application domain objects. If an application is developed with ORM 
// entity framework then this layer holds POCO classes (Code First) or Edmx (Database First) with entities. These domain entities
// don't have any dependencies.
//
//It is a class library project.It holds POCO classes along with configuration classes.It represents the Domain Entities layer of 
// the onion architecture.These classes are used to create database tables. It’s a core and central part of the application.



// SPANISH:

// Es la parte central de la arquitectura.Contiene todos los objetos de dominio de aplicación.Si una aplicación se desarrolla con el 
// marco de la entidad ORM, esta capa contiene clases de POCO (Code First) o Edmx (Database First) con entidades.Estas entidades 
// de dominio no tienen ninguna dependencia.
//
// Es un proyecto de biblioteca de clases "DomainEntitiesLayer".Contiene clases de POCO junto con clases de configuración.Representa la capa de 
// entidades de dominio de la arquitectura de cebolla.Estas clases se utilizan para crear tablas de base de datos. Es una parte 
// central de la aplicación.

using System;
namespace DomainEntitiesLayer
{
    public class Class1
    {

    }
}

