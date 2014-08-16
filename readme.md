## Problem Definition:

Create an application that allows end-users to track vehicles they own and the MPG they are currently experiencing on that vehicle.

* Users must authenticate with the system and will be either a standard user or an administrator.
* Standard users may perform the following operations 
    * View their vehicles. Each vehicle is identified with a Make (Toyota, MINI, Chevrolet, etc.) and the MPG.
    * Add a new vehicle, choosing the Make from a list and entering the MPG.
    * Edit an existing vehicle, changing the MPG, but not the make.
    * Delete a vehicle.
* Administrators may perform the standard user operations and additionally may: 
    * Edit the set of known makes, adding, editing, or deleting makes.
    * Generate a report of the minimum, maximum, and average MPG of all vehicles in the system by make.

The candidate is responsible for designing the data model and choosing an appropriate storage mechanism for persisting the data.


## Considerations:

* Add logging.
* Add exception handling.
* Add validation, client-side and server-side.
* Add a real auth system.
* See various comments throughout code regarding possibly better ways to do things (such as action filters for auth).
* Why it's usually a bad idea to expose raw ids in the dom, api, etc.
* So yeah, pure (jquery-pure) ajax... probably would be better to use Angular JS for this.  Purists might say to go with Vanilla JS.  *shrugs*
* Probably could use a pass just do double check that nothing extraneous has been left in, data-ids and such.
* How chatty the saves are with the server.
* Templating and the joys of maintaining something in multiple places.