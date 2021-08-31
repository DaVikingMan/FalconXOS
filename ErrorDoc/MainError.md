# This file lists the main errors and their fixes

### Error 0102(ENDO-INPUT ERROR)

This usually means that the command which you have typed as an input doesn't match the input which FalconXOS's input stream had expected.
For example, if you have typed '/force exit' instead of '/command Exit'
This error only occurs in else-if or if-else statements(and sometimes in if statements)

### Error 0323-e(EXO-INPUT ERROR)

This error occurs outside of else-if or if statements.
This means that the input which you have given does not match a command name

### Error 0102-internal(INFO ERROR)

This is an extremely rare error and usually occurs when there is an error in the code typed or the feature is incomplete(and I had added the error to inform that this part is not completed)

### Error 02302internal(PATH ERROR)

This is the same as Error 3 but occurs when the correct path is not assigned
For example : instead of writing ../src, I have written '/src'

### Error internal102(FALCONXOS ERROR)

This is a FalconXOS error and should be reported to the issues tab if found

Note : For now, the ErrorList is implemented manually and occurs when you have typed something wrong.
From version .20, the error system will be automatic.
