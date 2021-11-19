# DotNetAPIs
Pacchetti utili per fare API con .NET<br><hr>

##  ApiExceptions
Eccezioni custom per gestire più velocemente codici di errore sia dal lato server che da quello client<br><br>
- Errori server:
  - InternalServerError (500)<br><br>
- Errori client:
  - BadRequest (400)
  - Unauthorized (401)
  - NotFound (404)



## FileSystem.Net
Semplice explorer per il file-system del server su cui è contenuta l'API<br><br>
<b>Funzione principale:</b>
```
DataBuilder.GetFolderData(string Path)
```
Ritorna un oggetto "FolderData" contenente l'elenco dei percorsi di file e cartelle nella path richiesta
 
## JWT
Libreria per creare e verificare un HTTP bearer token secondo la tecnologia JSON Web Token<br><br>
Le <b>funzioni principali</b> sono:
```
Issuer.IssueToken(Payload<T> payload)
Validator.ValidateToken(string Token)
```
