# JWT

# TO DO

* Invalidate token unexpired after logout
* Refresh token

# Authentication

Client gets "401 Unauthorized" if:

* Client modifies JWT
* Server doesn't validate JWT using its own secret key on server side
* JWT is expired

"401 Unauthorized" status code indicates that the request lacks valid authentication credentials. 

# Authorization

Client gets "403 Forbidden" if:

* Client tries to access a resource (endpoint for example in a API) and it doesn't have the permission (example, role: Admin), 

"403 Forbidden" status code signifies that the server understands the request but refuses to fulfill it.

## API Validations

Endpoint:

* No [Authorize]: No Authentication
* [Authorize]: There is Authentication
* [Authorize(Roles = "Admin")]: There is Authentication and Authorization for user with role equals Admin

# JWT JSON

![JWT](./image-1.png)

# Flow

![JWT flow](./image-2.png)

# Advantages:

- Ligthweight
- It can be used in mulitple platforms like web, mobile, desktop and etc
- Json. Easy to parse
- Stateless. Server doesn't need to store user data (state) on server 

# Disadvantages:

- Manually mark non-expired JWT as invalid on logout
- Should not store sensitive info since it is stored on client-side
- On client-side, it should be stored in a safe place.

# Refresh tokens 

```
+--------+                                           +---------------+
  |        |--(A)------- Authorization Grant --------->|               |
  |        |                                           |               |
  |        |<-(B)----------- Access Token -------------|               |
  |        |               & Refresh Token             |               |
  |        |                                           |               |
  |        |                            +----------+   |               |
  |        |--(C)---- Access Token ---->|          |   |               |
  |        |                            |          |   |               |
  |        |<-(D)- Protected Resource --| Resource |   | Authorization |
  | Client |                            |  Server  |   |     Server    |
  |        |--(E)--- Expired Token ---->|          |   |               |
  |        |                            |          |   |               |
  |        |<-(F)- Invalid Token Error -|          |   |               |
  |        |                            +----------+   |               |
  |        |                                           |               |
  |        |--(G)----------- Refresh Token ----------->|               |
  |        |                                           |               |
  |        |<-(H)----------- Access Token -------------|               |
  +--------+           & Optional Refresh Token        +---------------+
  ```