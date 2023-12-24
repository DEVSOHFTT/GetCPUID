# CodigoUnicoPC

Este programa en C# genera un ID único para una computadora basado en el ID del procesador y una clave aleatoria. Es útil para generar identificadores únicos para sistemas locales.

## Funcionalidad

El programa consta de dos funciones principales:

1. **GetCPUId**: Obtiene el ID del procesador utilizando la clase `Win32_Processor` de WMI.

2. **GetKey**: Genera una clave aleatoria basada en la longitud del ID del procesador.
