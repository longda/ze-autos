<img src="http://i.giphy.com/tAhQVg4rBfKfK.gif" alt="ze autos: beep beep" />

:blue_car: Create an application that allows end-users to track vehicles they own and the MPG they are currently experiencing on that vehicle.

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
* Pagination.
* More ui feedback like progress bars and throbbers when communicating with the server.
* More unit tests.
* Cascading delete shenanigans.
* Sorting?


:feelsgood:


## Setup:
1. Deploy database.  This can be done via the provided db project.
2. Build and launch code from Visual Studio.
3. Admin Login:
    * u: auto
    * p: [enter anything]
4. Standard Login (always the same user in this demo):
    * u: [enter anything]
    * p: [enter anything]
