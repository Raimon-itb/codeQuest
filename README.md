# codeQuest
Exercici entregable codeQuest

CASE 1

| # Instruction | # Iteration | Variables                           | Condition                                        |
| ------------- | ----------- | ----------------------------------- | ------------------------------------------------ |
| 1             | -           | `op = 1`                            | Usuario selecciona opción válida del menú        |
| 2             | -           | `nameWizard = "arwen"`              | Entrada de nombre válida (solo texto)            |
| 3             | -           | `nameWizard = "Arwen"`              | Se formatea: primera mayúscula, resto minúsculas |
| 4             | 1–5         | `level = 1 + rnd(1–10) (acumulado)` | Se ejecuta bucle de 5 días de entrenamiento      |
| 5             | -           | `20 <= level < 30`                  | Se muestra `LowLevel` y `rankWizard = RankC`     |
| 6             | -           | `rankWizard = "Zyn the Buggued"`    | Output: `RankMessage` con rango C                |

| # Instruction | # Iteration | Variables                            | Condition                         |
| ------------- | ----------- | ------------------------------------ | --------------------------------- |
| 1             | -           | `op = 1`                             | Opción correcta                   |
| 2             | -           | `nameWizard = "merlin"` → `"Merlin"` | Nombre formateado                 |
| 3             | 1–5         | `level` crece hasta `>= 40`          | Entrenamiento genera nivel alto   |
| 4             | -           | `level >= 40`                        | Se muestra `specialLevel`         |
| 5             | -           | `rankWizard = RankS`                 | Output: `RankMessage` con rango S |

| # Instruction | # Iteration | Variables                        | Condition                                                                          |
| ------------- | ----------- | -------------------------------- | ---------------------------------------------------------------------------------- |
| 1             | -           | `op = "x"` (no numérico)         | Lanza excepción en conversión                                                      |
| 2             | -           | `validInput = false`             | Se muestra `InputErrorMessage` y vuelve al menú                                    |
| 3             | -           | `op = 1`                         | Nueva selección correcta                                                           |
| 4             | -           | `nameWizard = ""` (cadena vacía) | Posible `ArgumentOutOfRangeException` en `Substring` (error a detectar en pruebas) |

CASE 2
| # Instruction | # Iteration   | Variables                                              | Condition                              |
| ------------- | ------------- | ------------------------------------------------------ | -------------------------------------- |
| 1             | -             | `op = 2`                                               | Opción válida                          |
| 2             | 1–5           | `randomMonster = rnd(0–7)`                             | Se elige monstruo aleatorio            |
| 3             | 1–5           | `hp = monsterRosterHp[randomMonster]`                  | Vida inicial del monstruo              |
| 4             | bucle interno | `valorDice = rnd(0–5)` → `hp -= dicesValor[valorDice]` | Mientras `hp > 0` se muestra dado      |
| 5             | -             | `hp <= 0`                                              | Output: `MonsterDeathMessage`          |
| 6             | 1–5           | `level++`                                              | Nivel aumenta una vez por monstruo     |
| 7             | -             | `level_final = level_inicial + 5`                      | Output: `CurrentLevelMessage` correcto |

| # Instruction | # Iteration   | Variables                                       | Condition                                                                             |
| ------------- | ------------- | ----------------------------------------------- | ------------------------------------------------------------------------------------- |
| 1             | -             | `op = 2` con `level` ya alto (ej. 38)           | -                                                                                     |
| 2             | 1–5           | Monstruo aleatorio, incluyendo `Ancient Dragon` | Se prueban valores máximos de `monsterRosterHp`                                       |
| 3             | bucle interno | Dado cae muchas veces en valor 1                | Se verifica que el bucle termina aunque haya muchos golpes                            |
| 4             | -             | `level` pasa de `<40` a `>=40`                  | Después de este case, `rankWizard` podría ser S tras case 1 o uso posterior de case 6 |

| # Instruction | # Iteration | Variables            | Condition                                       |
| ------------- | ----------- | -------------------- | ----------------------------------------------- |
| 1             | -           | `op = "dos"`         | Conversión falla                                |
| 2             | -           | `validInput = false` | Output: `InputErrorMessage` y no entra a case 2 |

CASE 3
| # Instruction | # Iteration | Variables                          | Condition                                            |
| ------------- | ----------- | ---------------------------------- | ---------------------------------------------------- |
| 1             | -           | `op = 3`                           | Se entra al minijuego                                |
| 2             | -           | `attempts = 5`, `size = 5`         | Inicialización correcta de matrices                  |
| 3             | 1–5         | `x,y` dentro de `0..4`             | Coordenadas válidas                                  |
| 4             | 1–5         | `mineHidden[x,y] == 1` o `0`       | Marca `🪙` o `❌` en `mineVisible`                    |
| 5             | -           | `bits = bits_inicial + recompensa` | Output final: `"You now have {bits} bits."` correcto |

| # Instruction | # Iteration | Variables                                        | Condition                                                |
| ------------- | ----------- | ------------------------------------------------ | -------------------------------------------------------- |
| 1             | -           | `op = 3` con `bits` inicial alto                 | -                                                        |
| 2             | 1–5         | Usuario acierta en todas las casillas con moneda | `mineHidden[x,y]==1` en cada intento                     |
| 3             | 1–5         | `reward = rnd(5–50)` → máximo cercano a `250`    | `bits_final = bits_inicial + suma_rewards`               |
| 4             | -           | `bits` muy grande                                | Verificar que no hay overflow y se muestra bien el valor |

| # Instruction | # Iteration | Variables                          | Condition                                                          |
| ------------- | ----------- | ---------------------------------- | ------------------------------------------------------------------ |
| 1             | -           | `op = 3`                           | -                                                                  |
| 2             | 1           | `x = 7`, `y = -1`                  | Fuera de rango                                                     |
| 3             | 1           | `validCoordinates = false`         | Output: `"Coordinates must be between 0 and 4."`                   |
| 4             | 1           | `x = "a"` (no numérico)            | Se lanza excepción en `int.Parse`                                  |
| 5             | 1           | catch → `validCoordinates = false` | Output: `"Invalid input. Enter numbers only."` y se repite intento |

CASE 4
| # Instruction | # Iteration | Variables               | Condition                            |
| ------------- | ----------- | ----------------------- | ------------------------------------ |
| 1             | -           | `op = 4`                | Opción válida                        |
| 2             | -           | `inventory.Length == 0` | Output: `"Your inventory is empty."` |

| # Instruction | # Iteration | Variables                                       | Condition                                      |
| ------------- | ----------- | ----------------------------------------------- | ---------------------------------------------- |
| 1             | -           | `inventory` lleno (ej: tras comprar 5 ítems)    | -                                              |
| 2             | -           | `op = 4`                                        | Se entra a mostrar inventario                  |
| 3             | 1–N         | Se recorre `for (i=0; i<inventory.Length; i++)` | Se imprime `Slot i+1: inventory[i]` para todos |
| 4             | -           | Último `Slot` = último objeto comprado          | Lista completa, sin omisiones                  |

| # Instruction | # Iteration | Variables               | Condition                                       |
| ------------- | ----------- | ----------------------- | ----------------------------------------------- |
| 1             | -           | `op = "cuatro"` (texto) | Falla conversión                                |
| 2             | -           | `validInput = false`    | Output: `InputErrorMessage` y no ejecuta case 4 |

CASE 5
| # Instruction | # Iteration | Variables                               | Condition                         |
| ------------- | ----------- | --------------------------------------- | --------------------------------- |
| 1             | -           | `op = 5`                                | Opción válida                     |
| 2             | -           | `bits = 100` (por ejemplo)              | Bits suficientes                  |
| 3             | -           | `storeOption = 1`                       | Elige `"Iron Dagger"`             |
| 4             | -           | `price = priceObject[0] = 30`           | `bits >= price`                   |
| 5             | -           | `bits = 100 - 30 = 70`                  | Resta correcta                    |
| 6             | -           | `inventory` redimensionado +1           | Último slot = `"Iron Dagger 🗡️"` |
| 7             | -           | Output: `"You bought Iron Dagger 🗡️!"` | Compra exitosa                    |

| # Instruction | # Iteration | Variables                                     | Condition                            |
| ------------- | ----------- | --------------------------------------------- | ------------------------------------ |
| 1             | -           | `op = 5`, `bits` muy alto (ej: 500)           | -                                    |
| 2             | 1–5         | `storeOption = 1..5` en sucesivas ejecuciones | Compra todos los objetos             |
| 3             | 1–5         | `inventory.Length` incrementa hasta 5 (o más) | Todos los objetos añadidos sin error |
| 4             | -           | `bits_final = bits_inicial - suma(precios)`   | Verificar cálculo límite             |

| # Instruction | # Iteration | Variables                                       | Condition                                     |
| ------------- | ----------- | ----------------------------------------------- | --------------------------------------------- |
| 1             | -           | `op = 5`                                        | -                                             |
| 2             | -           | `bits = 10`, `storeOption = 1` (precio 30)      | `bits < price`                                |
| 3             | -           | No se modifica `inventory`                      | Output: `"Not enough bits to buy this item."` |
| 4             | -           | `storeOption = 9`                               | Opción fuera de rango                         |
| 5             | -           | `validStore = true` pero `storeOption > length` | Output: `"Invalid option."`                   |
| 6             | -           | `storeOption = "x"`                             | `validStore = false` → `"Invalid option."`    |

CASE 6
| # Instruction | # Iteration            | Variables                                    | Condition                                               |
| ------------- | ---------------------- | -------------------------------------------- | ------------------------------------------------------- |
| 1             | -                      | `rankWizard = RankC` (asignado desde case 1) | -                                                       |
| 2             | -                      | `op = 6`                                     | Muestra ataques según rango                             |
| 3             | 1–`attacksLvl2.Length` | Recorre `attacksLevel[1][i]`                 | Output: `"You can use this attacks: Fireball 🔥"`, etc. |

| # Instruction | # Iteration            | Variables                             | Condition                                |
| ------------- | ---------------------- | ------------------------------------- | ---------------------------------------- |
| 1             | -                      | `rankWizard = RankS`                  | -                                        |
| 2             | -                      | `op = 6`                              | Entra a case 6                           |
| 3             | 1–`attacksLvl5.Length` | Recorre `attacksLevel[4][i]`          | Se imprimen todos los ataques de nivel 5 |
| 4             | -                      | Última línea = `"Elemental Storm ⛈️"` | Ataques máximos disponibles              |

| # Instruction | # Iteration | Variables                                           | Condition                                                            |
| ------------- | ----------- | --------------------------------------------------- | -------------------------------------------------------------------- |
| 1             | -           | `rankWizard = "Unknown"` (usuario nunca usó case 1) | Valor por defecto                                                    |
| 2             | -           | `op = 6`                                            | Entra en case 6                                                      |
| 3             | -           | Ningún `if (rankWizard == RankX)` se cumple         | **No se muestra ningún ataque** (comportamiento límite a documentar) |

CASE 7
| # Instruction | # Iteration  | Variables                                      | Condition                                               |
| ------------- | ------------ | ---------------------------------------------- | ------------------------------------------------------- |
| 1             | -            | `op = 7`                                       | Opción válida                                           |
| 2             | -            | `sop = 2`                                      | Selecciona segundo scroll                               |
| 3             | -            | `scroll2VowelCount = 0`                        | Inicialización                                          |
| 4             | por carácter | `letter ∈ Scroll2`                             | Si `vowels.Contains(letter)` → `scroll2VowelCount++`    |
| 5             | -            | Fin del foreach                                | `scroll2VowelCount` contiene número correcto de vocales |
| 6             | -            | Output: `"Second scroll has been deciphered."` | Mensaje mostrado                                        |

| # Instruction | # Iteration | Variables                                     | Condition                                                   |
| ------------- | ----------- | --------------------------------------------- | ----------------------------------------------------------- |
| 1             | -           | `op = 7`                                      | -                                                           |
| 2             | -           | `sop = 3`                                     | Tercer scroll con muchos números                            |
| 3             | por dígito  | `character ∈ "1234567890"`                    | `scroll3Descipher = scroll3Descipher.Replace(character,"")` |
| 4             | -           | Todos los dígitos reemplazados                | Cadena resultante solo con texto y espacios                 |
| 5             | -           | Output: `"Third scroll has been deciphered."` | Mensaje correcto                                            |

| # Instruction | # Iteration | Variables                                     | Condition                         |
| ------------- | ----------- | --------------------------------------------- | --------------------------------- |
| 1             | -           | `op = 7`                                      | -                                 |
| 2             | -           | `sop = "x"` (no numérico)                     | Falla en `Convert.ToInt32`        |
| 3             | -           | `scrollValidInput = false`                    | Output: `InputErrorMessageScroll` |
| 4             | -           | Vuelve al menú principal sin descifrar scroll | Flujo de error controlado         |


