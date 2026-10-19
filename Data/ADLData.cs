using ADLDecisionTool.Models;

namespace ADLDecisionTool.Data;

public static class ADLData
{
    public static List<ADL> GetADLs()
    {
        return new List<ADL>
        {
            new ADL
            {
                Name = "AADL",
                SystemTypes = new List<string>
                {
                    "Sistemas embebidos"
                },
                Domains = new List<string>
                {
                    "Aeroespacial",
                    "Nuclear"
                },
                Characteristics = new List<string>
                {
                    "Soporte en tiempo real",
                    "Generación de código",
                    "Capacidad de análisis",
                    "Software y hardware",
                    "Hazard Model Annex (HMA)",
                    "Propiedades",
                    "Estándar ARINC 653",
                    "Arquitectura estática",
                    "Requisitos de tiempo",
                    "Colas sobrecargadas",
                    "Simulación"
                },
                Benefits = new List<string>
                {
                    "Mejora iterativa",
                    "Validación y verificación temprana",
                    "Reducción de costos",
                    "Mayor precisión en la especificación",
                    "Reducción de código manual"
                },
                Limitations = new List<string>
                {
                    "Falta de estándar",
                    "Aún necesita patrones de modelado",
                    "Complejidad alta para cumplir restricciones de planificación"
                },
                Tools = new List<string>
                {
                    "RAMSES",
                    "OSATE",
                    "Ocarina",
                    "RESOLUTE",
                    "REAL",
                    "Alloy",
                    "Signal",
                    "Simulink",
                    "AO4AADL",
                    "OCL",
                    "DEVS Annex",
                    "AADL-DEVS",
                    "ADCoDE"
                }
            },

            new ADL
            {
                Name = "EAST-ADL",
                SystemTypes = new List<string>
                {
                    
                },
                Domains = new List<string>
                {
                    "Automotriz"
                },
                Characteristics = new List<string>
                {
                    "Confiabilidad",
                    "Generación automática de modelos",
                    "Control en tiempo de ejecución",
                    "Restricciones",
                    "Requisitos de tiempo",
                    "Autosar"
                },
                Benefits = new List<string>
                {
                    "Centralización del proceso de desarrollo",
                    "Extensibilidad del ADL para agregar nuevos módulos",
                    "Permite realizar modificaciones rápidas"
                },
                Limitations = new List<string>
                {
                    "Versatilidad limita potencial"
                },
                Tools = new List<string>
                {
                    "AUTOSAR Gateway (CEA)",
                    "Eatop",
                    "Eclipse-Native tools",
                    "EMF"
                }
            },

            new ADL
            {
                Name = "SosADL",
                SystemTypes = new List<string>
                {
                    "Sistemas de sistemas (SoS)"
                },
                Domains = new List<string>
                {
                    "Gestión de emergencias"
                },
                Characteristics = new List<string>
                {
                    "Términos abstractos",
                    "Mediadores",
                    "Descripción en tiempo de diseño",
                    "Verificación",
                    "Control en tiempo de ejecución",
                    "Arquitectura evolutiva",
                    "Basado en π-calculus",
                    "Correcciones",
                    "Sistemas constituyentes",
                    "Coaliciones",
                    "Traducción a DEVS",
                    "Modelos estocásticos",
                    "No determinista",
                    "Incertidumbre de comportamiento"
                },
                Benefits = new List<string>
                {
                    "Validación y verificación temprana"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                    "ADE",
                    "EMF",
                    "Sirius",
                    "Xtext",
                    "Coq",
                    "DEVS",
                    "Eclipse Mars",
                    "PLASMA",
                    "UPAAL",
                    "SosADL Studio",
                    "Alloy",
                    "SosADL Simulator"
                }
            },

            new ADL
            {
                Name = "SysADL",
                SystemTypes = new List<string>
                {
                    "Sistemas embebidos",
                    "Sistemas distribuidos"
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Capacidad de análisis",
                    "Modelos SysML",
                    "Ecuaciones",
                    "Precondiciones",
                    "Poscondiciones",
                    "Extiende SysML"
                },
                Benefits = new List<string>
                {
                    "Mayor claridad",
                    "Validación y verificación temprana"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                    "SysADL Studio",
                    "EMF",
                    "Sirius",
                    "Xtext"
                }
            },

            new ADL
            {
                Name = "AO-ADL",
                SystemTypes = new List<string>
                {
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Flexibilidad",
                    "Preocupaciones transversales",
                    "Basado en XML",
                    "Reutilización",
                    "Cifrado",
                    "VML",
                    "Orientado a aspectos",
                    "Orden de funciones transversales"
                },
                Benefits = new List<string>
                {
                    "Reutilización de elementos de comúnes",
                    "Extensibilidad del ADL para agregar nuevos módulos"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                    "AO-ADL Tool Suite"
                }
            },

            new ADL
            {
                Name = "ACME",
                SystemTypes = new List<string>
                {
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Flexibilidad",
                    "Restricciones",
                    "Facilidad de intercambio entre ADLs",
                    "Complemento"
                },
                Benefits = new List<string>
                {
                },
                Limitations = new List<string>
                {
                    "Falta de herramientas de soporte",
                    "Incapacidad de asignar elementos de código"
                },
                Tools = new List<string>
                {
                }
            },

            new ADL
            {
                Name = "Breeze/ADL",
                SystemTypes = new List<string>
                {
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Basado en XML",
                    "Capacidad de análisis",
                    "Producciones",
                    "SASC"
                },
                Benefits = new List<string>
                {
                },
                Limitations = new List<string>
                {
                    "Necesidad de una traducción intermedia"
                },
                Tools = new List<string>
                {
                    "Tool Breeze",
                    "NuSVM",
                    "GMF"
                }
            },

            new ADL
            {
                Name = "Wright",
                SystemTypes = new List<string>
                {
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Método formal",
                },
                Benefits = new List<string>
                {
                    
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                }
            },

            new ADL
            {
                Name = "SOADL-P",
                SystemTypes = new List<string>
                {
                    "Sistemas orientados a servicios"
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Modelado de rendimiento",
                    "Basado en xADL",
                    "Rendimiento"
                },
                Benefits = new List<string>
                {
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                }
            },

            new ADL
            {
                Name = "Sarch",
                SystemTypes = new List<string>
                {
                    "Sistemas distribuidos",
                    "Sistemas orientados a servicios"
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Descripción de cualquier tipo de arquitectura"
                },
                Benefits = new List<string>
                {
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                }
            },

            new ADL
            {
                Name = "Multi-labeled graphs",
                SystemTypes = new List<string>
                {
                    "Sistemas de sistemas (SoS)"
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Verificación"
                },
                Benefits = new List<string>
                {
                    "Mayor facilidad de entendimiento"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                    "GMTE"
                }
            },

            new ADL
            {
                Name = "π-ADL",
                SystemTypes = new List<string>
                {
                    "Sistemas de sistemas (SoS)"
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Control en tiempo de ejecución",
                    "Generación de código",
                    "Parámetros de calidad"
                },
                Benefits = new List<string>
                {
                    "Validación y verificación temprana"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                    "Xtext",
                    "Go",
                    "DynBTL"
                }
            },

            new ADL
            {
                Name = "Arch-SoS",
                SystemTypes = new List<string>
                {
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Control en tiempo de ejecución",
                    "Interoperabilidad",
                    "Comportamiento emergente",
                    "Modelo de referencia"
                },
                Benefits = new List<string>
                {
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                }
            },

            new ADL
            {
                Name = "SAwUML",
                SystemTypes = new List<string>
                {
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Control en tiempo de ejecución",
                    "UML",
                    "ProMeLa",
                    "DbC",
                    "LTL",
                    "Comprobación de interbloqueo"
                },
                Benefits = new List<string>
                {
                    "Mayor facilidad de entendimiento",
                    "Mejora la comunicación"
                },
                Limitations = new List<string>
                {
                    "Problemas de verificación y análisis"
                },
                Tools = new List<string>
                {
                    "SAwUML's toolset"
                }
            },

            new ADL
            {
                Name = "CogArch-ADL",
                SystemTypes = new List<string>
                {
                    "Sistemas multiagente/cognitivos"
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Control en tiempo de ejecución",
                    "Control cognitivo multiagente"
                },
                Benefits = new List<string>
                {
                    "Mejora la comunicación"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                }
            },

            new ADL
            {
                Name = "DSOPL-ADL",
                SystemTypes = new List<string>
                {
                    "Sistemas dinámicos"
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Generación de código"
                },
                Benefits = new List<string>
                {
                    "Mejora la comunicación"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                }
            },

            new ADL
            {
                Name = "MontiArc",
                SystemTypes = new List<string>
                {
                    "Sistemas embebidos",
                    "Sistemas distribuidos"
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Generación de código"
                },
                Benefits = new List<string>
                {
                    "Mejora la comunicación"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                    "MontiGem"
                }
            },

            new ADL
            {
                Name = "ARCHERY",
                SystemTypes = new List<string>
                {
                    "Sistemas embebidos",
                    "Sistemas distribuidos"
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Restricciones",
                    "Bisimulación"
                },
                Benefits = new List<string>
                {
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                }
            },

            new ADL
            {
                Name = "DynADL",
                SystemTypes = new List<string>
                {
                    "Sistemas dinámicos"
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Control en tiempo de ejecución",
                    "Generación de código",
                    "Colas de mensaje"
                },
                Benefits = new List<string>
                {
                    "Ejecución dinámica",
                    "Reducción de código manual"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                    "POSIX",
                    "Bitsery"
                }
            },

            new ADL
            {
                Name = "PCM",
                SystemTypes = new List<string>
                {
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Políticas de vulnerabilidades",
                    "Operaciones arbitrarias"
                },
                Benefits = new List<string>
                {
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                    "C4C"
                }
            },

            new ADL
            {
                Name = "CLACS",
                SystemTypes = new List<string>
                {
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Componentes de restricción",
                    "ACL"
                },
                Benefits = new List<string>
                {
                    "Reutilización de elementos de comúnes",
                    "Automatización de la traducción de especificaciones textuales de restricciones arquitectónicas"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                }
            },

            new ADL
            {
                Name = "xADL",
                SystemTypes = new List<string>
                {
                },
                Domains = new List<string>
                {
                },
                Characteristics = new List<string>
                {
                    "Basado en XML",
                    "Sintaxis extensa"
                },
                Benefits = new List<string>
                {
                    "Extensibilidad del ADL para agregar nuevos módulos",
                    "Adopción Flexibilidad según las necesidades del dominio",
                    "Reutilización de elementos de comúnes"
                },
                Limitations = new List<string>
                {
                },
                Tools = new List<string>
                {
                    "Xlink",
                    "ArchStudio"
                }
            }
        };
    }

    public static List<string> GetSystemTypes()
    {
        return GetADLs()
            .SelectMany(adl => adl.SystemTypes)
            .Distinct()
            .OrderBy(type => type)
            .ToList();
    }

    public static List<string> GetDomains()
    {
        return GetADLs()
            .SelectMany(adl => adl.Domains)
            .Distinct()
            .OrderBy(domain => domain)
            .ToList();
    }

    public static List<string> GetCharacteristics()
    {
        return GetADLs()
            .SelectMany(adl => adl.Characteristics)
            .Distinct()
            .OrderBy(characteristic => characteristic)
            .ToList();
    }
}