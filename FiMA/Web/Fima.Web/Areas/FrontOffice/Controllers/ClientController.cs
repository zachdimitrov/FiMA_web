namespace Fima.Web.Areas.FrontOffice.Controllers
{
    using System;
    using System.Web.Mvc;
    using Common;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using Models.Client;
    using Services.Data.Contracts;
    using Web.Controllers;
    using Data.DbModels;
    using Infrastructure.Mapping;
    using System.Linq;

    public class ClientController : BaseController
    {
        private readonly ICountriesService countries;
        private readonly ICitiesService cities;
        private readonly IClientsService clients;
        private readonly IMunicipalitiesService municipalities;
        private readonly IBanksService banks;

        public ClientController(
            ICountriesService countries,
            ICitiesService cities,
            IClientsService clients,
            IMunicipalitiesService municipalities,
            IBanksService banks)
        {
            this.countries = countries;
            this.cities = cities;
            this.clients = clients;
            this.municipalities = municipalities;
            this.banks = banks;
        }

        // GET: FrontOffice/Client/AllClientIds
        // for ajax request - returns all personal Ids to check if input exists
        [HttpGet]
        public JsonResult AllClientIds()
        {
            var clientsPersonalIds = this.clients.AllPersonalIds();

            return this.Json(clientsPersonalIds, JsonRequestBehavior.AllowGet);
        }

        // GET: FrontOffice/Client/Representatives
        // for ajax request search and fill representative select form
        [HttpGet]
        public JsonResult Representatives()
        {
            var representatives = this.clients.GetAll()
                .To<RepSelectViewModel>()
                .ToList();

            return this.Json(representatives, JsonRequestBehavior.AllowGet);
        }

        // GET: FrontOffice/Client/Register
        [HttpGet]
        public ActionResult Register()
        {
            var model = new ClientRegisterViewModel();

            model.Countries = this.countries.AllNames();
            model.Cities = this.cities.AllNames();
            model.Banks = this.banks.AllNames();
            model.Municipalities = this.municipalities.AllNames();
            model.PERSONAL_ID_DATE = DateTime.Today.ToString("dd/MM/yyyy");
            model.CLIENT_BIRTHDATE = DateTime.Today.ToString("dd/MM/yyyy");

            return this.View(model);
        }

        // POST: FrontOffice/Client/Register
        [HttpPost]
        public ActionResult Register(ClientRegisterViewModel model)
        {
            var id = this.User.Identity.GetUserId();

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            // проверка за физическо или юридическо лице и създаване на FULL_NAME
            if (model.TYPE_PERSON == GlobalConstants.PerTypes[0] ||
                model.TYPE_PERSON == GlobalConstants.PerTypes[2])
            {
                model.FULL_NAME = model.FirmName;
            }
            else
            {
                model.FULL_NAME = $"{model.FIRSTNAME} {model.SECONDNAME} {model.LASTNAME}";
            }

            // TODO: създаване на тези неща
            model.CLIENTID_STRING = "00000000";
            model.CREATED_BY = int.Parse(id);
            model.CREATED_WHEN = DateTime.Now.ToString();
            model.CLIENTID = this.clients.GetNewId();

            /*Dim rst As ADODB.Recordset
    myuser = conn_sql.myuser   '' DLookup("[user]", "current_user")
    'mypass = DLookup("[pass]", "current_user")
    Dim userid As Integer
    userid = conn_sql.userid   ''DLookup("[user_int]", "current_user")
    'Call CONNECT_SQL
    'conn.Open MYCONN
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim udid As String
    udid = conn_sql.udid '' Trim(DLookup("[udid]", "tblcurrentud"))
    ''''''''''''''''''''''''''''''''''''''''''''''''''''


    '////////////////////////////////////////////////////////////////
    Dim i As Double
    rst = conn.Execute("exec sp_getmaxinvid")
    If rst.EOF Then
        i = 1
    Else
        i = rst.Fields("max_id").Value
        i = i + 1
    End If

    '////////////////////////////////////////////////////////////////
    'GET USER CLIENT STRING
    Dim clstring As String
    rst = conn.Execute("exec sp_getuserstring " _
        & userid & "")
    If rst.EOF Then
        MsgBox("Не мога да намеря код за потребителя!")
        Exit Sub
    Else
        clstring = rst.Fields("strindex").Value
    End If
    '///////////////////////////////////////////////////////////////
    Dim tempstr As String
    Dim tempstr2 As String
    Dim i2 As Integer
    Dim clidstring As String


    If udid = "AC" Then
        tempstr = "000000"
        i2 = Len(tempstr) - Len(Trim(i))
        tempstr2 = msvb.Left(tempstr, i2)
        clidstring = clstring & "-" & tempstr2 & i
    Else
        tempstr = "000000"
        i2 = Len(tempstr) - Len(Trim(i))
        tempstr2 = msvb.Left(tempstr, i2)
        clidstring = clstring & tempstr2 & i
    End If


    '///////////////////////////////////////////////////////////////////
    Dim fullnm As String
    If Me.cmbPERTYPE.Text = "БЪЛГАРСКО ФИЗИЧЕСКО ЛИЦЕ" Or Me.cmbPERTYPE.Text = "ЧУЖДО ФИЗИЧЕСКО ЛИЦЕ" Then
        fullnm = Me.txtFNAME.Text & " " & Me.txtSNAME.Text & " " & Me.txtLNAME.Text
    Else
        fullnm = Me.txtNAME.Text
    End If
    '///////////////////////////////////////////////////////////////////
    Dim crwhen As Date
    crwhen = Now()
    '///////////////////////////////////////////////////////////////////

    'MsgBox "exec sp_insertclient " _
    '& i & ", " _
    '& "'" & clidstring & "', '" & Forms!investor_create.txtID & "', 2, '" & Me.investor_create.cmbPERTYPE & "','" & Forms!investor_create.cmbORG & "', " _
    '& "'" & Forms!investor_create.txtFNAME & "', '" & Forms!investor_create.txtSNAME & "', '" & Forms!investor_create.txtLNAME & "', '" & fullnm & "','" & Forms!investor_create.txtIDNM & "', '" & Forms!investor_create.txtIDDATE & "', '" & Forms!investor_create.txtIDISSUE & "', '" & Forms!investor_create.cmbCOUNTRY & "', '" & Forms!investor_create.cmbTOWn & "', '" & Forms!investor_create.txtSTR & "', " _
    '& "'" & Forms!investor_create.txtEMAIL & "', '" & Forms!investor_create.txtPHONE & "', '" & Forms!investor_create.txtMOBILE & "', '" & Forms!investor_create.cmbREPTYPE & "', '" & Forms!investor_create.txtpylnomid1 & "', '" & Forms!investor_create.txtREP2 & "', '" & Forms!investor_create.cmbREPDATE & "', 'NONE', '" & Forms!investor_create.txtpylnomid2 & "', 'NONE', " _
    '& "'" & Forms!investor_create.txtDDS & "', '" & Forms!investor_create.txtTAXID & "', '" & Forms!investor_create.cmbEMPLOYEE & "', '" & Forms!investor_create.cmbBDATE & "', " _
    '& "'" & Forms!investor_create.txtIBAN & "', '" & Forms!investor_create.txtBIC & "', '" & Forms!investor_create.txtBANK & "', '" & Forms!investor_create.txtIBAN2 & "', '" & Forms!investor_create.txtBIC2 & "', '" & Forms!investor_create.txtBANK2 & "', '" & Forms!investor_create.txtIBAN3 & "', '" & Forms!investor_create.txtBIC3 & "', '" & Forms!investor_create.txtBANK3 & "', " _
    '& "'" & Forms!investor_create.txtNOTARY & "', 'NONE', 'NONE', 'OK', '" & Forms!investor_create.txtglobid & "', " & userid & ",'" & crwhen & "','" & Forms!investor_create.cmbregcd & "'"

    Dim dcit As String
    If Me.checkRES.Checked = True Then
        dcit = "YES"
    Else
        dcit = "NO"
    End If*/
            var newClient = new INVESTORS_FUNDS();
            this.Mapper.Map(model, newClient);
            this.clients.CreateClient(newClient);
            return this.RedirectToAction("Index", "Home");
        }
    }
}
