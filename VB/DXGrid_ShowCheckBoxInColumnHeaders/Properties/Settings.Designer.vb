' Developer Express Code Central Example:
' How to display a check box within column headers
' 
' This example demonstrates how to display a check box within column headers. If
' the check box is checked, the corresponding column is made read-only. Uncheck
' the check box to allow column values to be edited.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1517
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3074
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Namespace DXGrid_ShowCheckBoxInColumnHeaders.Properties

    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")>
    Friend NotInheritable Partial Class Settings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As DXGrid_ShowCheckBoxInColumnHeaders.Properties.Settings = CType((Global.System.Configuration.ApplicationSettingsBase.Synchronized(New DXGrid_ShowCheckBoxInColumnHeaders.Properties.Settings())), DXGrid_ShowCheckBoxInColumnHeaders.Properties.Settings)

        Public Shared ReadOnly Property [Default] As Settings
            Get
                Return DXGrid_ShowCheckBoxInColumnHeaders.Properties.Settings.defaultInstance
            End Get
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)>
        <Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb;Persist Se" & "curity Info=True")>
        Public ReadOnly Property nwindConnectionString As String
            Get
                Return(CStr((Me("nwindConnectionString"))))
            End Get
        End Property
    End Class
End Namespace
