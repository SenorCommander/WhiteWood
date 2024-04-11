﻿using Content.Shared.Administration.Notes;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Utility;

namespace Content.Client.Administration.UI.AdminRemarks;

[GenerateTypedNameReferences]
public sealed partial class AdminMessagePopupMessage : Control
{
    public AdminMessagePopupMessage(AdminMessageEuiState.Message message)
    {
        RobustXamlLoader.Load(this);

        Admin.SetMessage(FormattedMessage.FromMarkup(Loc.GetString(
            "admin-notes-message-admin",
            ("admin", message.AdminName),
            ("date", message.AddedOn.ToLocalTime()))));

        Message.SetMessage(message.Text);
    }
}