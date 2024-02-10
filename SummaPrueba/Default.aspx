<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SummaPrueba._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
<script src="~/Scripts/jquery-3.4.1.min.js"></script>
<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.5.2.min.js" type="text/javascript"></script>





   <div class="container px-4">
    <div class="row gx-5">
        <div class="col" style="border:solid; border-radius:22px;">
            <div class="p-3 text-center">Media</div>

            <form class="form-floating">
                <input type="text" class="form-control" id="mediaText">
                <label for="floatingInputValue">Tamaño Escalera</label>
                <div type="text" class="form-text">Separar los numeros por comas.</div>
            </form>

            <select class="form-select" id="selectAgenteMedia" disabled>
                <option value ="" selected>Seleccione el Agente</option>
                <option value="1">Agente A: Media aritmética o promedio</option>
                <option value="2">Agente B: Media armónica</option>
                <option value="3">Agente C: Mediana</option>
            </select>

            <div class="input-group mb-3">
                <span class="input-group-text" >media</span>
                <input type="text" class="form-control" id="resultadoMedia" readonly>
            </div>
        </div>


        <div class="col" style="border:solid; border-radius:22px;">
            <div class="p-3 text-center">Escaleras</div>

            <form class="form-floating">
                <input type="text" class="form-control" id="escaleraValue">
                <label for="floatingInputValue">Tamaño Escalera</label>
                <div type="text" class="form-text">ingrese un numero entre 0 y 100.</div>
            </form>

            <select class="form-select" id="selectAgenteEscalera" disabled>
                <option selected>Seleccione el Agente</option>
                <option value="1">Agente A: Base y altura iguales</option>
                <option value="2">Agente B: Cima y altura iguales</option>
                <option value="3">Agente C: Cima y base iguales</option>
            </select>

            <div class="input-group">
                <span class="input-group-text">Escaleras</span>
                <textarea class="form-control" id="resultadoEscalera" readonly></textarea>
            </div>
        </div>
    </div>
</div>
<script src="../Scripts/ScriptPage/Agente.js"></script>

</asp:Content>
