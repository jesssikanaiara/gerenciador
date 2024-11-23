import { HttpClient, HttpErrorResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { FiltroPaginacao } from '../modelos/filtro-paginacao.modelo';
import { PaginacaoRetorno } from '../modelos/paginacao-retorno.modelo';


export abstract class BaseService<T> {
  private baseUrl: string;

  public constructor(baseUrl: string, protected http?: HttpClient) {
    this.baseUrl = baseUrl;
  }

  public getAll(route?: string, param?: FiltroPaginacao): Observable<T[]> {
    return this.getAllWithType<T[]>(route, param);
  }
  
  public filtrar(route?: string, param?: FiltroPaginacao): Observable<PaginacaoRetorno<T>> {
    return this.getAllWithType<PaginacaoRetorno<T>>(route, param);
  }

  public getAllWithType<TYPE>(route?: string, param?: FiltroPaginacao): Observable<TYPE> {

    return this.http.get<TYPE>(this.getUrl(route), this.headers(param ? param.toHttpParams() : null)).pipe(map(res => {
      let body: any = res;
      if (body.data) {
        body = body.data;
      }
      return body || {};
    }), catchError(this.handleError));
  }

  public getById(id, route?: string): Observable<T> {
    if (route) {
      return this.http.get<T>(this.getUrl(`${route}/${id}`), this.headers()).pipe(catchError(this.handleError));
    } else {
      return this.http.get<T>(this.getUrl(`/${id}`), this.headers()).pipe(catchError(this.handleError));
    }
  }

  public getOne(route?: string): Observable<T> {
    if (!route) {
      route = '';
    }
    return this.http.get<T>(this.getUrl(route), this.headers()).pipe(catchError(this.handleError));
  }

  public post(entity: T, route?: string): Observable<T> {
    return this.http.post<T>(this.getUrl(route), entity, this.headers()).pipe(catchError(this.handleError));
  }

  public putWithPath(entity: T, route?: string): Observable<T> {
    return this.http.put<T>(this.getUrl(route), entity, this.headers()).pipe(catchError(this.handleError));
  }

  public put(entity: T, pathId: string, relativeUrl?: string): Observable<T> {
    const strId = pathId ? `${pathId}` : '';
    let url = `${strId}`;
    if (relativeUrl) {
      url = `${relativeUrl}/${strId}`;
    }
    return this.http.put<T>(
      this.getUrl(url), entity, this.headers()).pipe(catchError(this.handleError));
  }

  public delete(id: number): Observable<any> {
    return this.http.delete(this.getUrl('/' + id), this.headers()).pipe(catchError(this.handleError));
  }

  private extractData(res: Response): Response {
    let body: any = res;
    if (body.data) {
      body = body.data;
    }
    return body || {};
  }

  protected getUrl(relativeUrl?: string): string {
    let absoluteUrl = `${environment.apiBase}/${this.baseUrl}`;
    if (relativeUrl !== null && relativeUrl !== undefined) {
      absoluteUrl += relativeUrl;
    }
    return absoluteUrl;
  }

  public handleError(error: HttpErrorResponse) {
    console.log(error);

    if (error.error instanceof ErrorEvent) {
      console.error('An error occurred:', error.error.message);
    } 
    return throwError(error);
  }

  protected headers(param?: HttpParams) {
    const headerOptions: any = {
      'Content-Type': 'application/json',
      'cache': 'no-cache',
      'Access-Control-Allow-Origin': '*'
    };

    const httpOptions = {
      headers: new HttpHeaders(headerOptions),
      params: param
    };

    return httpOptions;
  }
}
