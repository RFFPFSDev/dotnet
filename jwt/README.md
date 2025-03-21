# JWT

# TO DO

* Invalidate refresh token after logout
* Implement HashPassword with salt

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

Instead of providing the user with an access token that has a long expiration time, issue a short-lived access token along with a refresh token

Reason of using Refresh token: 
* Validating a signed token is less costly, but revoking is difficult. By having the access tokens be short lived, JWT easily expires rather than revoked explicitly.
* Access tokens are exchanged with (potentially many) resource servers, which increases the chance of leakage. Refresh tokens are only ever exchanged with the authorization server. Again, the short-livedness of access tokens is at least some level of mitigation.

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
  |        |<-(H)----------- New Access Token ---------|               |
  +--------+									       +---------------+
  ```