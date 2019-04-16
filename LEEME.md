# Arquitectura de cebolla en ASP.NET Core MVC

# Introducción
El término Onion Architecture fue acuñado por Jeffrey Palermo en 2008. Esta arquitectura proporciona una mejor manera de crear aplicaciones para una mejor capacidad de prueba, facilidad de mantenimiento y confiabilidad de las infraestructuras, como las bases de datos y los servicios. El objetivo principal de esta arquitectura es abordar los desafíos que enfrentan la arquitectura de 3 niveles o la arquitectura de n niveles, y proporcionar una solución para problemas comunes, como el acoplamiento y la separación de inquietudes. Hay dos tipos de acoplamiento: acoplamiento apretado y acoplamiento suelto.

## Acoplamiento apretado

Cuando una clase depende de una dependencia concreta, se dice que está estrechamente relacionada con esa clase. Un objeto estrechamente acoplado depende de otro objeto; eso significa cambiar un objeto en una aplicación estrechamente acoplada, a menudo requiere cambios en una cantidad de otros objetos. No es difícil cuando una aplicación es pequeña, pero en una aplicación de nivel empresarial, es demasiado difícil hacer los cambios.

## Bajo acoplamiento

Significa que dos objetos son independientes y un objeto puede usar otro objeto sin depender de él. Es un objetivo de diseño que busca reducir las interdependencias entre los componentes de un sistema con el objetivo de reducir el riesgo de que los cambios en un componente requieran cambios en cualquier otro componente.

# Ventajas de la arquitectura de cebolla

Hay varias ventajas de la arquitectura de cebolla, que se enumeran a continuación.

1. Proporciona una mejor capacidad de mantenimiento, ya que todos los códigos dependen de las capas o del centro.
2. Proporciona una mejor capacidad de prueba ya que la prueba de la unidad se puede crear para capas separadas sin el efecto de otros módulos de la aplicación.
3. Desarrolla una aplicación ligeramente acoplada ya que la capa externa de la aplicación siempre se comunica con la capa interna a través de interfaces.
4. Cualquier implantación de hormigón se proporcionaría a la aplicación en el tiempo de ejecución
5. Las entidades de dominio son parte central y central. Puede tener acceso tanto a la base de datos como a las capas de UI.
6. Las capas internas nunca dependen de la capa externa. El código que puede haber cambiado debe ser parte de una capa externa.

# Por qué la arquitectura de la cebolla

Hay varias arquitecturas tradicionales, como la arquitectura de 3 niveles y la arquitectura de n niveles, todas con sus pros y sus contras. Todas estas arquitecturas tradicionales tienen algunos problemas fundamentales, tales como: un acoplamiento estrecho y una separación de preocupaciones. El Model-View-Controller es la arquitectura de aplicaciones web más utilizada en estos días. Resuelve el problema de la separación de la preocupación, ya que existe una separación entre la IU, la lógica empresarial y la lógica de acceso a los datos. La vista se utiliza para diseñar la interfaz de usuario. El modelo se utiliza para pasar los datos entre View y Controller en los que la lógica de negocios realiza cualquier operación. El controlador se utiliza para manejar la solicitud web mediante métodos de acción y devuelve la vista en consecuencia. Por lo tanto, resuelve el problema de la separación de la preocupación mientras que el Controlador todavía se utiliza para la lógica de acceso a la base de datos. En esencia,

Por otro lado, Onion Architecture aborda tanto la separación de preocupaciones como los problemas de acoplamiento apretado. La filosofía general de la arquitectura de la cebolla es mantener la lógica de negocios, la lógica de acceso a los datos y el modelo en el medio de la aplicación y empujar las dependencias lo más hacia fuera posible significa que todos se acoplan hacia el centro.

# Capas de arquitectura de cebolla

Esta arquitectura se basa en gran medida en el principio de inversión de dependencia. La interfaz de usuario se comunica con la lógica empresarial a través de interfaces. Tiene cuatro capas

1. Domain Entities Layer

2. Repository Layer

3. Service Layer

4. UI (Web/Unit Test) Layer

   ![](https://github.com/imyourpartner/MyFiles/blob/master/8540.onion-1.PNG-439x435.png)

1. Capa de entidades de dominio
2. Capa de repositorio
3. Capa de servicio
4. Capa UI (Web / Unit Test)

Estas capas están hacia el centro. La parte central es las entidades de dominio que representan los objetos de negocio y comportamiento. Estas capas pueden variar, pero la capa de entidades de dominio siempre es parte del centro. La otra capa define más el comportamiento de un objeto. Veamos cada capa una por una.

## Capa de entidades de dominio

Es la parte central de la arquitectura. Contiene todos los objetos de dominio de aplicación. Si una aplicación se desarrolla con el marco de la entidad ORM, esta capa contiene clases de POCO (Code First) o Edmx (Database First) con entidades. Estas entidades de dominio no tienen ninguna dependencia.

## Capa de repositorio

El objetivo de la capa es crear una capa de abstracción entre la capa de entidades de dominio y la capa de lógica de negocios de una aplicación. Es un patrón de acceso a datos que solicita un enfoque de acceso a datos más débilmente acoplado. Creamos un repositorio genérico, que consulta el origen de datos para los datos, asigna los datos del origen de datos a una entidad comercial y persiste los cambios en la entidad comercial al origen de datos.

## Capa de servicio

La capa contiene interfaces que se utilizan para comunicarse entre la capa UI y la capa de repositorio. Mantiene la lógica de negocios para una entidad, por lo que también se denomina capa de lógica de negocios.

## Capa de interfaz de usuario

Es la capa más externa. Podría ser la aplicación web, la API web o el proyecto de prueba unitaria. Esta capa tiene una implementación del Principio de Inversión de Dependencia para que la aplicación construya una aplicación acoplada libremente. Se comunica a la capa interna a través de interfaces.

# Estructura del proyecto de arquitectura de cebolla

Para implementar la arquitectura Onion, desarrollamos una aplicación Core ASP.NET. Esta aplicación realiza operaciones de CRUD en entidades. La aplicación contiene cuatro proyectos según la figura 2. Cada proyecto representa una capa en la arquitectura de cebolla.



