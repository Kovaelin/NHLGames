﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    'à l'aide d'un outil, tel que ResGen ou Visual Studio.
    'Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    'avec l'option /str ou régénérez votre projet VS.
    '''<summary>
    '''  Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Public Class French
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("NHLGames.French", GetType(French).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Remplace la propriété CurrentUICulture du thread actuel pour toutes
        '''  les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 3) Ajouter.
        '''</summary>
        Public Shared ReadOnly Property btnAddHosts() As String
            Get
                Return ResourceManager.GetString("btnAddHosts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 4) Nettoyer.
        '''</summary>
        Public Shared ReadOnly Property btnCleanHosts() As String
            Get
                Return ResourceManager.GetString("btnCleanHosts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Effacer.
        '''</summary>
        Public Shared ReadOnly Property btnClearConsole() As String
            Get
                Return ResourceManager.GetString("btnClearConsole", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Copier au presse-papier.
        '''</summary>
        Public Shared ReadOnly Property btnCopyConsole() As String
            Get
                Return ResourceManager.GetString("btnCopyConsole", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 2) Voir Hosts.
        '''</summary>
        Public Shared ReadOnly Property btnOpenHostsFile() As String
            Get
                Return ResourceManager.GetString("btnOpenHostsFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 1) Tester.
        '''</summary>
        Public Shared ReadOnly Property btnTestHosts() As String
            Get
                Return ResourceManager.GetString("btnTestHosts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Résultats finaux.
        '''</summary>
        Public Shared ReadOnly Property chkShowFinalScores() As String
            Get
                Return ResourceManager.GetString("chkShowFinalScores", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Résultats en direct.
        '''</summary>
        Public Shared ReadOnly Property chkShowLiveScores() As String
            Get
                Return ResourceManager.GetString("chkShowLiveScores", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Détails des séries.
        '''</summary>
        Public Shared ReadOnly Property chkShowSeriesRecord() As String
            Get
                Return ResourceManager.GetString("chkShowSeriesRecord", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à En cours.
        '''</summary>
        Public Shared ReadOnly Property enumending() As String
            Get
                Return ResourceManager.GetString("enumending", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Terminé.
        '''</summary>
        Public Shared ReadOnly Property enumfinal() As String
            Get
                Return ResourceManager.GetString("enumfinal", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à En cours.
        '''</summary>
        Public Shared ReadOnly Property enuminprogress() As String
            Get
                Return ResourceManager.GetString("enuminprogress", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Avant-match.
        '''</summary>
        Public Shared ReadOnly Property enumpregame() As String
            Get
                Return ResourceManager.GetString("enumpregame", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à À venir.
        '''</summary>
        Public Shared ReadOnly Property enumscheduled() As String
            Get
                Return ResourceManager.GetString("enumscheduled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à GB/Heure.
        '''</summary>
        Public Shared ReadOnly Property formatGbHour() As String
            Get
                Return ResourceManager.GetString("formatGbHour", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à MB/Heure.
        '''</summary>
        Public Shared ReadOnly Property formatMbHour() As String
            Get
                Return ResourceManager.GetString("formatMbHour", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à {0} {2} {1} {3}.
        '''</summary>
        Public Shared ReadOnly Property formatWeekMonthDayYear() As String
            Get
                Return ResourceManager.GetString("formatWeekMonthDayYear", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 1ere.
        '''</summary>
        Public Shared ReadOnly Property gamePeriod1() As String
            Get
                Return ResourceManager.GetString("gamePeriod1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 2eme.
        '''</summary>
        Public Shared ReadOnly Property gamePeriod2() As String
            Get
                Return ResourceManager.GetString("gamePeriod2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 3eme.
        '''</summary>
        Public Shared ReadOnly Property gamePeriod3() As String
            Get
                Return ResourceManager.GetString("gamePeriod3", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Terminé.
        '''</summary>
        Public Shared ReadOnly Property gamePeriodFinal() As String
            Get
                Return ResourceManager.GetString("gamePeriodFinal", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à P.
        '''</summary>
        Public Shared ReadOnly Property gamePeriodOt() As String
            Get
                Return ResourceManager.GetString("gamePeriodOt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à {0}E P.
        '''</summary>
        Public Shared ReadOnly Property gamePeriodOtMore() As String
            Get
                Return ResourceManager.GetString("gamePeriodOtMore", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à mène.
        '''</summary>
        Public Shared ReadOnly Property gameSeriesLead() As String
            Get
                Return ResourceManager.GetString("gameSeriesLead", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à égale.
        '''</summary>
        Public Shared ReadOnly Property gameSeriesTied() As String
            Get
                Return ResourceManager.GetString("gameSeriesTied", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à gagne.
        '''</summary>
        Public Shared ReadOnly Property gameSeriesWin() As String
            Get
                Return ResourceManager.GetString("gameSeriesWin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Visiteurs : {1} {0}.
        '''</summary>
        Public Shared ReadOnly Property lblAwayTeam() As String
            Get
                Return ResourceManager.GetString("lblAwayTeam", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à {0} vues de camera.
        '''</summary>
        Public Shared ReadOnly Property lblCamViews() As String
            Get
                Return ResourceManager.GetString("lblCamViews", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Réseau de diffusion.
        '''</summary>
        Public Shared ReadOnly Property lblCdn() As String
            Get
                Return ResourceManager.GetString("lblCdn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Caméra zone {0}.
        '''</summary>
        Public Shared ReadOnly Property lblEndzoneCam() As String
            Get
                Return ResourceManager.GetString("lblEndzoneCam", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à English.
        '''</summary>
        Public Shared ReadOnly Property lblEnglish() As String
            Get
                Return ResourceManager.GetString("lblEnglish", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Français.
        '''</summary>
        Public Shared ReadOnly Property lblFrench() As String
            Get
                Return ResourceManager.GetString("lblFrench", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Stream canadien français.
        '''</summary>
        Public Shared ReadOnly Property lblFrenchNetwork() As String
            Get
                Return ResourceManager.GetString("lblFrenchNetwork", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Match {0}.
        '''</summary>
        Public Shared ReadOnly Property lblGame() As String
            Get
                Return ResourceManager.GetString("lblGame", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à M{0}: {1}.
        '''</summary>
        Public Shared ReadOnly Property lblGameAbv() As String
            Get
                Return ResourceManager.GetString("lblGameAbv", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Télécharger MPC.
        '''</summary>
        Public Shared ReadOnly Property lblGetMpc() As String
            Get
                Return ResourceManager.GetString("lblGetMpc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Télécharger VLC.
        '''</summary>
        Public Shared ReadOnly Property lblGetVlc() As String
            Get
                Return ResourceManager.GetString("lblGetVlc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Locaux : {1} {0}.
        '''</summary>
        Public Shared ReadOnly Property lblHomeTeam() As String
            Get
                Return ResourceManager.GetString("lblHomeTeam", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Nom de domaine.
        '''</summary>
        Public Shared ReadOnly Property lblHostname() As String
            Get
                Return ResourceManager.GetString("lblHostname", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Fichier Hosts (entrée).
        '''</summary>
        Public Shared ReadOnly Property lblHosts() As String
            Get
                Return ResourceManager.GetString("lblHosts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Langue.
        '''</summary>
        Public Shared ReadOnly Property lblLanguage() As String
            Get
                Return ResourceManager.GetString("lblLanguage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Emplacement MPC.
        '''</summary>
        Public Shared ReadOnly Property lblMpcPath() As String
            Get
                Return ResourceManager.GetString("lblMpcPath", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Emplacement MPV.
        '''</summary>
        Public Shared ReadOnly Property lblMpvPath() As String
            Get
                Return ResourceManager.GetString("lblMpvPath", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Stream national.
        '''</summary>
        Public Shared ReadOnly Property lblNationalNetwork() As String
            Get
                Return ResourceManager.GetString("lblNationalNetwork", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Aucun match trouvé.
        '''</summary>
        Public Shared ReadOnly Property lblNoGames() As String
            Get
                Return ResourceManager.GetString("lblNoGames", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Aucun stream de disponible.
        '''</summary>
        Public Shared ReadOnly Property lblNoStreamAvailable() As String
            Get
                Return ResourceManager.GetString("lblNoStreamAvailable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Note: Veuillez rafraîchir la grille des matchs pour obtenir le changement de diffuseur.
        '''</summary>
        Public Shared ReadOnly Property lblNoteCdn() As String
            Get
                Return ResourceManager.GetString("lblNoteCdn", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à  sur {0}.
        '''</summary>
        Public Shared ReadOnly Property lblOnNetwork() As String
            Get
                Return ResourceManager.GetString("lblOnNetwork", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Emplacement de sauvegarde.
        '''</summary>
        Public Shared ReadOnly Property lblOutput() As String
            Get
                Return ResourceManager.GetString("lblOutput", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Lecteur par défaut.
        '''</summary>
        Public Shared ReadOnly Property lblPlayer() As String
            Get
                Return ResourceManager.GetString("lblPlayer", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Lecteur args. supp..
        '''</summary>
        Public Shared ReadOnly Property lblPlayerArgs() As String
            Get
                Return ResourceManager.GetString("lblPlayerArgs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Séries.
        '''</summary>
        Public Shared ReadOnly Property lblPlayoffs() As String
            Get
                Return ResourceManager.GetString("lblPlayoffs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Présaison.
        '''</summary>
        Public Shared ReadOnly Property lblPreseason() As String
            Get
                Return ResourceManager.GetString("lblPreseason", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Qualité vidéo.
        '''</summary>
        Public Shared ReadOnly Property lblQuality() As String
            Get
                Return ResourceManager.GetString("lblQuality", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Camera de l&apos;arbitre.
        '''</summary>
        Public Shared ReadOnly Property lblRefCam() As String
            Get
                Return ResourceManager.GetString("lblRefCam", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Afficher les résultats.
        '''</summary>
        Public Shared ReadOnly Property lblShowScores() As String
            Get
                Return ResourceManager.GetString("lblShowScores", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Emplacement Streamlink.
        '''</summary>
        Public Shared ReadOnly Property lblSlPath() As String
            Get
                Return ResourceManager.GetString("lblSlPath", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Streams disponible durant l&apos;avant-match.
        '''</summary>
        Public Shared ReadOnly Property lblStreamAvailableDuringPregame() As String
            Get
                Return ResourceManager.GetString("lblStreamAvailableDuringPregame", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Streamlink args. supp..
        '''</summary>
        Public Shared ReadOnly Property lblStreamerArgs() As String
            Get
                Return ResourceManager.GetString("lblStreamerArgs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à {0} stream.
        '''</summary>
        Public Shared ReadOnly Property lblTeamStream() As String
            Get
                Return ResourceManager.GetString("lblTeamStream", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Emplacement VLC.
        '''</summary>
        Public Shared ReadOnly Property lblVlcPath() As String
            Get
                Return ResourceManager.GetString("lblVlcPath", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Aujourd&apos;hui.
        '''</summary>
        Public Shared ReadOnly Property lnkCalendarToday() As String
            Get
                Return ResourceManager.GetString("lnkCalendarToday", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ajouter l&apos;entrée du serveur au fichier Hosts.
        '''</summary>
        Public Shared ReadOnly Property msgAddHost() As String
            Get
                Return ResourceManager.GetString("msgAddHost", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Version {0} maintenant disponible! Changements: {1}{2}{3}.
        '''</summary>
        Public Shared ReadOnly Property msgChangeLog() As String
            Get
                Return ResourceManager.GetString("msgChangeLog", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Besoin d&apos;aide?.
        '''</summary>
        Public Shared ReadOnly Property msgDiySteps() As String
            Get
                Return ResourceManager.GetString("msgDiySteps", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Cette ligne doit se trouver dans votre fichier Hosts : {0}{1} {2}{0}Cliquez sur &apos;Ouvrir Hosts&apos; pour accéder au fichier Hosts et ajouter (Ctrl+V) la ligne copiée à la fin du fichier Hosts.{0}Désirez-vous copier cette ligne d&apos;entrée au presse-papier?.
        '''</summary>
        Public Shared ReadOnly Property msgDiyStepsText() As String
            Get
                Return ResourceManager.GetString("msgDiyStepsText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Une erreur est survenue! Voir la console pour plus de détails.{0}Cliquez sur le bouton [?] dans le coin supérieur droit pour voir la documentation en anglais de NHLGames et obtenir un support rapide dans la section &apos;Support&apos; (Application et Lecteur){0}Vous pouvez copier le contenu de la console avec le bouton &apos;Copier au presse-papier&apos; et coller (CTRL+V) dans un nouveau sujet sur reddit /r/NHLGames pour obtenir de l&apos;aide. Utilisez le lien en bas à gauche pour vous y rendre..
        '''</summary>
        Public Shared ReadOnly Property msgErrorGeneralText() As String
            Get
                Return ResourceManager.GetString("msgErrorGeneralText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Erreur.
        '''</summary>
        Public Shared ReadOnly Property msgFailure() As String
            Get
                Return ResourceManager.GetString("msgFailure", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Matchs trouvés : {0}.
        '''</summary>
        Public Shared ReadOnly Property msgGamesFound() As String
            Get
                Return ResourceManager.GetString("msgGamesFound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à NHLGames ne peut pas fonctionner sans avoir son nom de domaine inscrit dans le fichier Hosts de Windows. Acceptez-vous que NHLGames ajoute une entrée à votre fichier Hosts, ainsi Windows pourra résoudre le nom de domaine de NHLGames et pourra se connecter à son adresse IP?.
        '''</summary>
        Public Shared ReadOnly Property msgHostnameSet() As String
            Get
                Return ResourceManager.GetString("msgHostnameSet", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à L&apos;entrée dans le fichier Hosts ne semble pas fonctionner :(.
        '''</summary>
        Public Shared ReadOnly Property msgHostsFailure() As String
            Get
                Return ResourceManager.GetString("msgHostsFailure", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le fichier Hosts semble fonctionnel :).
        '''</summary>
        Public Shared ReadOnly Property msgHostsSuccess() As String
            Get
                Return ResourceManager.GetString("msgHostsSuccess", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Chargement des matchs.
        '''</summary>
        Public Shared ReadOnly Property msgLoadingGames() As String
            Get
                Return ResourceManager.GetString("msgLoadingGames", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Nouvelle version disponible.
        '''</summary>
        Public Shared ReadOnly Property msgNewVersionAvailable() As String
            Get
                Return ResourceManager.GetString("msgNewVersionAvailable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Une nouvelle version est disponible, téléchargez la plus récente version {0} sur /r/nhl_games.
        '''</summary>
        Public Shared ReadOnly Property msgNewVersionText() As String
            Get
                Return ResourceManager.GetString("msgNewVersionText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Retirer l&apos;entrée du serveur au fichier Hosts.
        '''</summary>
        Public Shared ReadOnly Property msgRemoveHost() As String
            Get
                Return ResourceManager.GetString("msgRemoveHost", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Accès d&apos;administrateur requis.
        '''</summary>
        Public Shared ReadOnly Property msgRunAsAdmin() As String
            Get
                Return ResourceManager.GetString("msgRunAsAdmin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à NHLGames requiert une entrée au fichier Hosts qui est manquante. Voulez-vous qu&apos;elle redémarre avec le droit d&apos;administrateur et l&apos;ajoute l&apos;entrée manquante?.
        '''</summary>
        Public Shared ReadOnly Property msgRunAsAdminText() As String
            Get
                Return ResourceManager.GetString("msgRunAsAdminText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Succès.
        '''</summary>
        Public Shared ReadOnly Property msgSuccess() As String
            Get
                Return ResourceManager.GetString("msgSuccess", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à {0} vs {1}.
        '''</summary>
        Public Shared ReadOnly Property msgTeamVsTeam() As String
            Get
                Return ResourceManager.GetString("msgTeamVsTeam", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Tester le fichier Hosts.
        '''</summary>
        Public Shared ReadOnly Property msgTestHosts() As String
            Get
                Return ResourceManager.GetString("msgTestHosts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Voir le fichier Hosts.
        '''</summary>
        Public Shared ReadOnly Property msgViewHosts() As String
            Get
                Return ResourceManager.GetString("msgViewHosts", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Voulez-vous voir les changements apportés au fichier Hosts?.
        '''</summary>
        Public Shared ReadOnly Property msgViewHostsText() As String
            Get
                Return ResourceManager.GetString("msgViewHostsText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Console.
        '''</summary>
        Public Shared ReadOnly Property tabConsole() As String
            Get
                Return ResourceManager.GetString("tabConsole", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Matchs.
        '''</summary>
        Public Shared ReadOnly Property tabGames() As String
            Get
                Return ResourceManager.GetString("tabGames", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Modules.
        '''</summary>
        Public Shared ReadOnly Property tabModules() As String
            Get
                Return ResourceManager.GetString("tabModules", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Paramètres.
        '''</summary>
        Public Shared ReadOnly Property tabSettings() As String
            Get
                Return ResourceManager.GetString("tabSettings", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
