# About Signals

Signals are text which is sent to the component for the part of FalconXOS which received it to give an output for the signal.
For example, if you type '-d info', FalconXOS sends a signal 'Request Debug Info!' which asks Zero to give an output for this command.

There are two types of signals:
-signed signals
-unsigned signals

Signed signals can interact with all components and have error handling.
To sign a signal, you need to add '! anywhere in the signal.
Unsigned signals are made for debugging and testing purposes and don't have error-handling and can't interact with components by default.

Unsigned signals are made to test and implement new error handlers or components.
For example, if you want to make your own error-handler and components, you can use unsigned signals instead of signed signals.