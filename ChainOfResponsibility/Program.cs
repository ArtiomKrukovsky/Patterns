using ChainOfResponsibility.Handlers.ConcreteHandlers;
using ChainOfResponsibility.Models;

var request = new Request("System request");

var authenticationHandler = new AuthenticationHandler();
var authorizationHandler = new AuthorizationHandler();
var validationHandler = new ValidationHandler();

authenticationHandler.SetNextHandler(authorizationHandler);
authorizationHandler.SetNextHandler(validationHandler);

authenticationHandler.HandleRequest(request);
