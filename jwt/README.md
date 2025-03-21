# JWT

# TO DO

* Invalidate token unexpired after logout
* Refresh token

# Authentication

If client modifies JWT or if server doesn't validate JWT using its own secret key on server side, client gets "401 Unauthorized"

"401 Unauthorized" status code indicates that the request lacks valid authentication credentials. 

# Authorization

If client tries to access a resource (endpoint for example in a API) and it doesn't have the permission (example, role: Admin), client gets "403 Forbidden"

"403 Forbidden" status code signifies that the server understands the request but refuses to fulfill it.

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
