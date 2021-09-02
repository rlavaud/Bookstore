﻿using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace TenantExtension.Blazor.Menus
{
    public class TenantExtensionMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(TenantExtensionMenus.Prefix, displayName: "TenantExtension", "/TenantExtension", icon: "fa fa-globe"));
            
            return Task.CompletedTask;
        }
    }
}