import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { NomeId } from "../modelos/nome-id.modelo";
import { BaseService } from "./base.service";

@Injectable({
    providedIn: 'root'
  })
export class DominioService extends BaseService<any>{
    constructor(public http: HttpClient) {
        super('dominio', http);
    }

    public categorias() : Array<NomeId>{
        return [
            {nome: 'Carne Bovina', id: 1},
        ];
    }
}