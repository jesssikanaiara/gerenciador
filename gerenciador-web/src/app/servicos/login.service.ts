import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { throwError } from "rxjs";
import { Observable } from "rxjs";
import { catchError } from "rxjs/operators";
import { environment } from "src/environments/environment";
import { Cliente } from "../modelos/cliente.modelo";
import { LoginResultado } from "../modelos/login.model";
import { BaseService } from "./base.service";

@Injectable({
    providedIn: 'root'
})
export class LoginService {
    constructor(public http: HttpClient) {
    }

    public async signIn(email: String, senha: String): Promise<boolean> {
        var result = await this.http.post<LoginResultado>(
            this.getUrl(), 
            { email: email, senha: senha }, 
            this.headers()
        ).toPromise();
        
        if(result != null){
            localStorage.setItem('token', result.token);
            localStorage.setItem('user', JSON.stringify(result.user));
            return true;
        }

        return false;
    }

    protected getUrl(): string {
        return `${environment.apiBase}/Auth/SignIn`;
    }

    protected headers() {
        const headerOptions: any = {
            'Content-Type': 'application/json',
            'cache': 'no-cache',
            'Access-Control-Allow-Origin': '*'
        };

        const httpOptions = {
            headers: new HttpHeaders(headerOptions)
        };

        return httpOptions;
    }

    public handleError(error: HttpErrorResponse) {
        console.log(error);

        if (error.error instanceof ErrorEvent) {
            console.error('An error occurred:', error.error.message);
        }
        return throwError(error);
    }
}