# About Components in FalconXOS

Components are not main parts of FalconXOS, they are supporting parts which help FalconXOS run.

All components are in the 'Components', and different components are divided into different folders.

Components are one of the most important parts of FalconXOS as they help the entire app to run and maintain all errors.

There are three Components:
-Zero
-Shiro
-Gray

## About Zero

Zero is one of the most important of FalconXOS.
It handles all interactions of FalconXOS.

It is mainly used as a exchanger and receiver.

If you type '-d info', that signal goes to the Zero component and then Zero gives FalconXOS the info to output.

-------------------------------------------------------------------------

Command->Zero->Output
This is how Zero interacts with FalconXOS

Zero has a sub-component called 'Crow'.

Crow gives Zero the output which it needs to display for some commands.
Crow also handles some error-handling by sending the signal received by Zero to Shiro for error-checking.

## About Shiro

Shiro is the error handler of FalconXOS.
It handles all errors which occur in FalconXOS, including warning about the error and giving info about the error.

Shiro also has a sub-component which is one of the most important parts of Shiro.
The name of the sub-component is 'Kuroi'.
Kuroi reports serious errors, for example startup errors, input stream not working errors and code errors.

Shiro has another sub-component called 'Crowned', which is the component which gives info about errors.

For example, if you got a 'input doesn't match' error, the output or the text displayed when the error occurs is given by 'Crowned'

## About Gray

Errors in FalconXOS do not get directly reported to Shiro.
Instead they go through the 'Gray' component
Gray acts like an interactor between Shiro, FalconXOS and Zero and is used to send requests to these components.
It is the most important component in FalconXOS.