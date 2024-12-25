using System;
using System.Collections.Generic;
using System.Text;
using Flarum.Api.Bases.ModelBases;

namespace Flarum.Provider.Contracts.Models
{
    public interface IHasRelationships
    {
        FlarumRelationshipsBase GetFlarumRelationships();
    }
}
