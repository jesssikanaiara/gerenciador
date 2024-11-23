import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Produto } from "../modelos/produto.modelo";
import { BaseService } from "./base.service";

@Injectable({
    providedIn: 'root'
  })
export class ProdutoService extends BaseService<Produto>{
    constructor(public http: HttpClient) {
        super('produtos', http);
    }
}