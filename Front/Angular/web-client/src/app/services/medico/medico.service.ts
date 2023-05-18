import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Medico } from 'src/app/models/medico.model';

@Injectable({
  providedIn: 'root'
})
export class MedicoService {

  private readonly url: string;

  constructor(private httpClient: HttpClient) {
    this.url = "https://localhost:44341/api/Medicos";
  }

  getAll(): Observable<Medico[]> {
    return this.httpClient.get<Medico[]>(this.url); // => retorna um Observable de Medico[] (array de médicos)
  }

  getById(id: number): Observable<Medico> {
    return this.httpClient.get<Medico>(`${this.url}/${id}`); // => interpolação de string (template string)
  }

  post(medico: Medico): Observable<Medico> {
    return this.httpClient.post<Medico>(this.url, medico);
  }

  delete(id: number): Observable<Medico> { // Observable<any> => retorna um Observable de qualquer coisa
    return this.httpClient.delete<Medico>(`${this.url}/${id}`);
  }

  put(id: number, medico: Medico): Observable<Medico> {
    return this.httpClient.put<Medico>(`${this.url}/${id}`, medico);
  }

}
