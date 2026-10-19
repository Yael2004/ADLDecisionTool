using ADLDecisionTool.Models;

namespace ADLDecisionTool.Data;

public static class CharacteristicData
{
    public static List<Characteristic> GetCharacteristics()
    {
        
        var characteristics = new List<Characteristic>
        {
            new Characteristic
            {
                Name = "ACL",
                Description = ""
            },

            new Characteristic
            {
                Name = "Capacidad de análisis",
                Description = "Capacidad del ADL para soportar la evaluación y verificación de propiedades del sistema mediante herramientas o técnicas de análisis."
            },

            new Characteristic
            {
                Name = "Estándar ARINC 653",
                Description = "Estándar utilizado en la comunidad de aviónica que se centra en aislar el software en particiones, lo que permite cumplir con mayores requisitos de seguridad mientras se reduce la cantidad de procesadores necesarios en un sistema."
            },

            new Characteristic
            {
                Name = "Arquitectura estática",
                Description = "Arquitectura de software que se establece en la fase de diseño y que no cambia ni se modifica durante el tiempo de ejecución (run-time) del sistema."
            },

            new Characteristic
            {
                Name = "Arquitectura evolutiva",
                Description = "Principio que respalda la implementación de cambios de forma frecuente, pequeña e incremental a lo largo del tiempo, adoptando una metodología ágil para abarcar ciclos de retroalimentación."
            },

            new Characteristic
            {
                Name = "Autosar",
                Description = "AUTOSAR (por sus siglas en inglés, Automotive Open System Architecture) es un estándar y un marco de trabajo de arquitectura de software y de modelado diseñado específicamente para sistemas integrados de la industria automotriz."
            },

            new Characteristic
            {
                Name = "Basado en π-calculus",
                Description = ""
            },

            new Characteristic
            {
                Name = "Basado en XML",
                Description = "XML es un metalenguaje: de forma predeterminada, no hace nada más que permitir definir un lenguaje personalizado para describir datos propios. Los esquemas XML permiten, como arquitecto, especificar una estructura de información completa."
            },

            new Characteristic
            {
                Name = "Basado en xADL",
                Description = ""
            },

            new Characteristic
            {
                Name = "Bisimulación",
                Description = ""
            },

            new Characteristic
            {
                Name = "Cifrado",
                Description = "Mecanismo y atributo de calidad funcional de seguridad que se utiliza para garantizar la confidencialidad y la privacidad de la información."
            },

            new Characteristic
            {
                Name = "Coaliciones",
                Description = "Composiciones arquitectónicas o alianzas temporales para la acción combinada entre sistemas constituyentes conectados a través de mediadores."
            },

            new Characteristic
            {
                Name = "Colas de mensaje",
                Description = "Mecanismos de comunicación y conexión utilizados para transmitir datos e instrucciones entre distintos componentes o hilos de ejecución."
            },

            new Characteristic
            {
                Name = "Colas sobrecargadas",
                Description = "Gestión y dictamen de cómo debe reaccionar el sistema ante colas sobrecargadas."
            },

            new Characteristic
            {
                Name = "Complemento",
                Description = "Permite definir propiedades de los elementos para complementar la descripción del sistema."
            },

            new Characteristic
            {
                Name = "Componentes de restricción",
                Description = "Componentes de software en los cuales se integran y encapsulan explícitamente las restricciones de una arquitectura."
            },

             new Characteristic
            {
                Name = "Comportamiento emergente",
                Description = "Comportamiento o propiedad de un sistema a nivel macro que surge espontáneamente como resultado de las interacciones locales entre sus sistemas o partes constituyentes."
            },

            new Characteristic
            {
                Name = "Comprobación de interbloqueos",
                Description = "Análisis exhaustivo que se realiza sobre las especificaciones formales de una arquitectura de software para asegurar que el sistema no se quede atascado o bloqueado durante su ejecución."
            },

            new Characteristic
            {
                Name = "Confiabilidad",
                Description = "Atributo de calidad o requisito no funcional fundamental. Se asocia estrechamente con la tolerancia a fallos y la robustez de un sistema."
            },

            new Characteristic
            {
                Name = "Control cognitivo multiagente",
                Description = ""
            },

            new Characteristic
            {
                Name = "Control en tiempo de ejecución",
                Description = ""
            },

            new Characteristic
            {
                Name = "Correcciones",
                Description = ""
            },

            new Characteristic
            {
                Name = "DbC",
                Description = ""
            },

            new Characteristic
            {
                Name = "Descripción de cualquier tipo de arquitectura",
                Description = "Capacidad para permitir la descripción de cualquier arquitectura de software en cualquier estilo arquitectónico."
            },

            new Characteristic
            {
                Name = "Descripción en tiempo de diseño",
                Description = "Proceso de especificación y modelado de una arquitectura antes de su implementación y puesta en marcha en el tiempo de ejecución (run-time)."
            },

            new Characteristic
            {
                Name = "Ecuaciones",
                Description = "Expresión lógica sobre parámetros que se utiliza para especificar las restricciones que gobiernan la ejecución de las acciones y actividades de un componente."
            },

            new Characteristic
            {
                Name = "Extiende SysML",
                Description = ""
            },

            new Characteristic
            {
                Name = "Facilidad de intercambio entre ADLs",
                Description = ""
            },

            new Characteristic
            {
                Name = "Flexibilidad",
                Description = "Característica de una arquitectura, ADL o middleware que permite adaptaciones, expansiones y separaciones de responsabilidades con facilidad y de manera dinámica."
            },

            new Characteristic
            {
                Name = "Generación automática de modelos",
                Description = "Capacidad impulsada por la ingeniería basada en modelos (MDE) mediante la cual los sistemas y herramientas pueden transformar o generar automáticamente nuevas abstracciones o modelos derivados a partir de una especificación principal."
            },

            new Characteristic
            {
                Name = "Generación de código",
                Description = "Es el proceso automatizado mediante el cual las descripciones arquitectónicas de alto nivel y los modelos se transforman directamente en código fuente ejecutable, scripts de despliegue o prototipos operacionales."
            },

            new Characteristic
            {
                Name = "Hazard Model Annex (HMA)",
                Description = "Extensión del lenguaje de arquitectura AADL que permite especificar y modelar fuentes de peligros, mecanismos de activación de fallos y posibles accidentes (mishaps) en sistemas, con el objetivo de apoyar el análisis de seguridad en arquitecturas de sistemas embebidos."
            },

            new Characteristic
            {
                Name = "Interoperabilidad",
                Description = "Atributo o propiedad que exige que los distintos sistemas constituyentes, dispositivos y tecnologías puedan interactuar, intercambiar información y comunicarse de manera fluida y sin problemas para lograr un objetivo global, independientemente de sus profundas diferencias operativas, de fabricación o de heterogeneidad de red."
            },

            new Characteristic
            {
                Name = "Incertidumbre de comportamiento",
                Description = ""
            },

            new Characteristic
            {
                Name = "LTL",
                Description = ""
            },

            new Characteristic
            {
                Name = "Mediadores",
                Description = ""
            },

            new Characteristic
            {
                Name = "Método formal",
                Description = "Uso de técnicas matemáticas o basadas en lógica de rigurosidad demostrable para la especificación, desarrollo y verificación del diseño arquitectónico de un sistema."
            },

            new Characteristic
            {
                Name = "Modelado de rendimiento",
                Description = ""
            },

            new Characteristic
            {
                Name = "Modelo de referencia",
                Description = "División de la funcionalidad junto con el flujo de datos entre las partes, que define una descomposición estándar de un problema conocido en partes que lo resuelven de forma cooperativa."
            },

            new Characteristic
            {
                Name = "Modelos estocásticos",
                Description = ""
            },

            new Characteristic
            {
                Name = "Modelos SysML",
                Description = "ADLs o enfoques de diseño que utilizan el perfil o el estándar SysML (Systems Modeling Language) como base para modelar sistemas."
            },

            new Characteristic
            {
                Name = "No determinista",
                Description = ""
            },

            new Characteristic
            {
                Name = "Operaciones arbitrarias",
                Description = ""
            },

            new Characteristic
            {
                Name = "Orden de funciones transversales",
                Description = ""
            },

            new Characteristic
            {
                Name = "Orientado a aspectos",
                Description = ""
            },

            new Characteristic
            {
                Name = "Parámetros de calidad",
                Description = ""
            },

            new Characteristic
            {
                Name = "Políticas de vulnerabilidad",
                Description = ""
            },

            new Characteristic
            {
                Name = "Poscondiciones",
                Description = ""
            },

            new Characteristic
            {
                Name = "Precondiciones",
                Description = ""
            },

            new Characteristic
            {
                Name = "Preocupaciones transversales",
                Description = ""
            },

            new Characteristic
            {
                Name = "Producciones",
                Description = ""
            },

            new Characteristic
            {
                Name = "ProMeLa",
                Description = ""
            },

            new Characteristic
            {
                Name = "Propiedades",
                Description = "Representan la información semántica y las reglas asociadas a los elementos o estructuras en una arquitectura."
            },

            new Characteristic
            {
                Name = "Rendimiento",
                Description = "Atributo de calidad que se refiere a la capacidad de un sistema de software para cumplir con sus requisitos de tiempo de respuesta y procesamiento bajo determinadas cargas de trabajo, incluyendo el uso eficiente de recursos."
            },

            new Characteristic
            {
                Name = "Requisitos de tiempo",
                Description = ""
            },

            new Characteristic
            {
                Name = "Restricciones",
                Description = "Constituyen descripciones lógicas, rigurosas y verificables que formalizan condiciones puntuales impuestas a los elementos del diseño para resguardar la validez del sistema."
            },

            new Characteristic
            {
                Name = "Reutilización",
                Description = "Constituyen descripciones lógicas, rigurosas y verificables que formalizan condiciones puntuales impuestas a los elementos del diseño para resguardar la validez del sistema."
            },

            new Characteristic
            {
                Name = "SASC",
                Description = "Constituyen descripciones lógicas, rigurosas y verificables que formalizan condiciones puntuales impuestas a los elementos del diseño para resguardar la validez del sistema."
            },

            new Characteristic
            {
                Name = "Simulación",
                Description = ""
            },

            new Characteristic
            {
                Name = "Sintaxis extensa",
                Description = ""
            },

            new Characteristic
            {
                Name = "Sistemas constituyentes",
                Description = "En un Sistema de Sistemas (SoS), son los sistemas útiles e independientes que se integran o \"conectan en red\" para formar la arquitectura global."
            },

            new Characteristic
            {
                Name = "Software y hardware",
                Description = "Elementos estructurales que se modelan conjuntamente para describir arquitecturas de los sistemas. En el mismo modelo arquitectónico se representan los componentes lógicos de software (hilos, procesos, subprogramas) y la plataforma de ejecución física de hardware (procesadores, memoria, buses, dispositivos)."
            },

            new Characteristic
            {
                Name = "Soporte en tiempo real",
                Description = "Se refiere a la capacidad y rigor necesario para modelar y cumplir con las limitaciones de recursos y tiempos de respuesta exigentes de sistemas embebidos de criticidad alta."
            },

            new Characteristic
            {
                Name = "Términos abstractos",
                Description = ""
            },

            new Characteristic
            {
                Name = "Traducción a DEVS",
                Description = "Consiste en la transformación de un modelo arquitectónico estructural en un formalismo ejecutable capaz de simular el sistema a través de eventos discretos en el tiempo (DEVS)."
            },

            new Characteristic
            {
                Name = "UML",
                Description = "Es la herramienta y notación semiformal de modelado de software preferida y más utilizada por los profesionales de la industria."
            },

            new Characteristic
            {
                Name = "Verificación",
                Description = "Actividad crítica que consiste en comprobar analíticamente que la implementación de un software se ha modelado de forma correcta, confirmando tempranamente que el diseño arquitectónico satisface sin excepciones sus restricciones, atributos de calidad o requisitos de seguridad."
            },

            new Characteristic
            {
                Name = "VML",
                Description = "Lenguaje utilizado en la Ingeniería de Líneas de Productos de Software (SPL) para documentar y modelar la variación de opciones en un sistema."
            }
        };

        
        foreach (var characteristic in characteristics)
        {
            characteristic.Category = GetCategory(characteristic.Name);
        }

        return characteristics;
    }

    private static string GetCategory(string name)
{
    return name switch
    {
        "ACL" or
        "Basado en π-calculus" or
        "Basado en XML" or
        "Basado en xADL" or
        "Ecuaciones" or
        "Método formal" or
        "Modelo de referencia" or
        "Modelos SysML" or
        "Propiedades" or
        "Restricciones" or
        "Precondiciones" or
        "Poscondiciones" or
        "Descripción de cualquier tipo de arquitectura" or
        "Descripción en tiempo de diseño" or
        "Arquitectura estática" or
        "Arquitectura evolutiva" or
        "Componentes de restricción" or
        "Términos abstractos" or
        "Sintaxis extensa" or
        "UML" or
        "VML" or
        "SASC" or
        "ProMeLa" or
        "Extiende SysML" or
        "Complemento"
            => "Modelado y especificación",

        "Capacidad de análisis" or
        "Bisimulación" or
        "Comprobación de interbloqueos" or
        "Verificación" or
        "LTL" or
        "Modelos estocásticos" or
        "No determinista" or
        "Incertidumbre de comportamiento" or
        "Simulación" or
        "Traducción a DEVS" or
        "Control en tiempo de ejecución" or
        "Correcciones" or
        "Operaciones arbitrarias" or
        "Producciones" or
        "Colas sobrecargadas"
            => "Análisis y verificación",

        "Cifrado" or
        "Confiabilidad" or
        "Flexibilidad" or
        "Interoperabilidad" or
        "Parámetros de calidad" or
        "Políticas de vulnerabilidad" or
        "Rendimiento" or
        "Requisitos de tiempo" or
        "Soporte en tiempo real" or
        "Estándar ARINC 653" or
        "Hazard Model Annex (HMA)" or
        "Modelado de rendimiento" or
        "DbC"
            => "Calidad y seguridad",

        "Coaliciones" or
        "Colas de mensaje" or
        "Comportamiento emergente" or
        "Control cognitivo multiagente" or
        "Mediadores" or
        "Sistemas constituyentes" or
        "Software y hardware" or
        "Orientado a aspectos" or
        "Orden de funciones transversales" or
        "Preocupaciones transversales" or
        "Reutilización"
            => "Estructura y comportamiento",

        "Autosar" or
        "Facilidad de intercambio entre ADLs" or
        "Generación automática de modelos" or
        "Generación de código"
            => "Integración y herramientas",

        _ => "Otras características"
    };
}
}