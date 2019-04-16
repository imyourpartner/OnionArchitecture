# Arquitectura de cebolla en ASP.NET Core MVC

# Introducci�n
El t�rmino Onion Architecture fue acu�ado por Jeffrey Palermo en 2008. Esta arquitectura proporciona una mejor manera de crear aplicaciones para una mejor capacidad de prueba, facilidad de mantenimiento y confiabilidad de las infraestructuras, como las bases de datos y los servicios. El objetivo principal de esta arquitectura es abordar los desaf�os que enfrentan la arquitectura de 3 niveles o la arquitectura de n niveles, y proporcionar una soluci�n para problemas comunes, como el acoplamiento y la separaci�n de inquietudes. Hay dos tipos de acoplamiento: acoplamiento apretado y acoplamiento suelto.

## Acoplamiento apretado

Cuando una clase depende de una dependencia concreta, se dice que est� estrechamente relacionada con esa clase. Un objeto estrechamente acoplado depende de otro objeto; eso significa cambiar un objeto en una aplicaci�n estrechamente acoplada, a menudo requiere cambios en una cantidad de otros objetos. No es dif�cil cuando una aplicaci�n es peque�a, pero en una aplicaci�n de nivel empresarial, es demasiado dif�cil hacer los cambios.

## Bajo acoplamiento

Significa que dos objetos son independientes y un objeto puede usar otro objeto sin depender de �l. Es un objetivo de dise�o que busca reducir las interdependencias entre los componentes de un sistema con el objetivo de reducir el riesgo de que los cambios en un componente requieran cambios en cualquier otro componente.

# Ventajas de la arquitectura de cebolla

Hay varias ventajas de la arquitectura de cebolla, que se enumeran a continuaci�n.

1. Proporciona una mejor capacidad de mantenimiento, ya que todos los c�digos dependen de las capas o del centro.
2. Proporciona una mejor capacidad de prueba ya que la prueba de la unidad se puede crear para capas separadas sin el efecto de otros m�dulos de la aplicaci�n.
3. Desarrolla una aplicaci�n ligeramente acoplada ya que la capa externa de la aplicaci�n siempre se comunica con la capa interna a trav�s de interfaces.
4. Cualquier implantaci�n de hormig�n se proporcionar�a a la aplicaci�n en el tiempo de ejecuci�n
5. Las entidades de dominio son parte central y central. Puede tener acceso tanto a la base de datos como a las capas de UI.
6. Las capas internas nunca dependen de la capa externa. El c�digo que puede haber cambiado debe ser parte de una capa externa.

# Por qu� la arquitectura de la cebolla

Hay varias arquitecturas tradicionales, como la arquitectura de 3 niveles y la arquitectura de n niveles, todas con sus pros y sus contras. Todas estas arquitecturas tradicionales tienen algunos problemas fundamentales, tales como: un acoplamiento estrecho y una separaci�n de preocupaciones. El Model-View-Controller es la arquitectura de aplicaciones web m�s utilizada en estos d�as. Resuelve el problema de la separaci�n de la preocupaci�n, ya que existe una separaci�n entre la IU, la l�gica empresarial y la l�gica de acceso a los datos. La vista se utiliza para dise�ar la interfaz de usuario. El modelo se utiliza para pasar los datos entre View y Controller en los que la l�gica de negocios realiza cualquier operaci�n. El controlador se utiliza para manejar la solicitud web mediante m�todos de acci�n y devuelve la vista en consecuencia. Por lo tanto, resuelve el problema de la separaci�n de la preocupaci�n mientras que el Controlador todav�a se utiliza para la l�gica de acceso a la base de datos. En esencia,

Por otro lado, Onion Architecture aborda tanto la separaci�n de preocupaciones como los problemas de acoplamiento apretado. La filosof�a general de la arquitectura de la cebolla es mantener la l�gica de negocios, la l�gica de acceso a los datos y el modelo en el medio de la aplicaci�n y empujar las dependencias lo m�s hacia fuera posible significa que todos se acoplan hacia el centro.

# Capas de arquitectura de cebolla

Esta arquitectura se basa en gran medida en el principio de inversi�n de dependencia. La interfaz de usuario se comunica con la l�gica empresarial a trav�s de interfaces. Tiene cuatro capas

1. Domain Entities Layer

2. Repository Layer

3. Service Layer

4. UI (Web/Unit Test) Layer

   ![](https://github.com/imyourpartner/MyFiles/blob/master/8540.onion-1.PNG-439x435.png)

1. Capa de entidades de dominio
2. Capa de repositorio
3. Capa de servicio
4. Capa UI (Web / Unit Test)

Estas capas est�n hacia el centro. La parte central es las entidades de dominio que representan los objetos de negocio y comportamiento. Estas capas pueden variar, pero la capa de entidades de dominio siempre es parte del centro. La otra capa define m�s el comportamiento de un objeto. Veamos cada capa una por una.

## Capa de entidades de dominio

Es la parte central de la arquitectura. Contiene todos los objetos de dominio de aplicaci�n. Si una aplicaci�n se desarrolla con el marco de la entidad ORM, esta capa contiene clases de POCO (Code First) o Edmx (Database First) con entidades. Estas entidades de dominio no tienen ninguna dependencia.

## Capa de repositorio

El objetivo de la capa es crear una capa de abstracci�n entre la capa de entidades de dominio y la capa de l�gica de negocios de una aplicaci�n. Es un patr�n de acceso a datos que solicita un enfoque de acceso a datos m�s d�bilmente acoplado. Creamos un repositorio gen�rico, que consulta el origen de datos para los datos, asigna los datos del origen de datos a una entidad comercial y persiste los cambios en la entidad comercial al origen de datos.

## Capa de servicio

La capa contiene interfaces que se utilizan para comunicarse entre la capa UI y la capa de repositorio. Mantiene la l�gica de negocios para una entidad, por lo que tambi�n se denomina capa de l�gica de negocios.

## Capa de interfaz de usuario

Es la capa m�s externa. Podr�a ser la aplicaci�n web, la API web o el proyecto de prueba unitaria. Esta capa tiene una implementaci�n del Principio de Inversi�n de Dependencia para que la aplicaci�n construya una aplicaci�n acoplada libremente. Se comunica a la capa interna a trav�s de interfaces.

# Estructura del proyecto de arquitectura de cebolla

Para implementar la arquitectura Onion, desarrollamos una aplicaci�n Core ASP.NET. Esta aplicaci�n realiza operaciones de CRUD en entidades. La aplicaci�n contiene cuatro proyectos seg�n la figura 2. Cada proyecto representa una capa en la arquitectura de cebolla.



