import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  // PARA A API FUNCIONAR DEVE-SE COLAR A URL DENTRO DO LINK e ajustar a ROTA !!!


  // esse é de conta ra
  //apiUrl = 'https://sheet.best/api/sheets/41de3ebb-eb91-4fee-a8fc-60ff9330c178';
  // o de baixo é da conta jek
  apiUrl = '';
  // ^ https://sheet.best/api/sheets/b0d8f820-0085-4a70-81ee-cca78a7b5f17
  httpOptions = { // isso é apenas um exemplo de como passar dados pelo header da requisição
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    })
  }

  constructor(private httpClient: HttpClient) { }

  // Creat Read Update Delete

  // retorna a lista de users - Read
  getUsers(): Observable<User[]> {
    return this.httpClient.get<User[]>(this.apiUrl);
  }

  // salvar o user no banco - Create
  postUser(user: User): Observable<User> {
    return this.httpClient.post<User>(this.apiUrl, user, this.httpOptions);
  }

  // deleta o user do banco - Delete

  deleteUser(id: number): Observable<User> {
    return this.httpClient.delete<User>(`${this.apiUrl}/id/${id}`);
  }

  // edita usuário - Update

  updateUser(id: string, user: User): Observable<User> {
    return this.httpClient.put<User>(`${this.apiUrl}/id/${id}`, user, this.httpOptions);
  }

  // lista user único -

  getUser(id: string): Observable<User[]> {
    return this.httpClient.get<User[]>(`${this.apiUrl}/id/${id}`);
  }

}
