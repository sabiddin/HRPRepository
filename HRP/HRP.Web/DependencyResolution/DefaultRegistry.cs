// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HRP.Web.DependencyResolution {
    using HRP.Contracts.DataContracts;
    using HRP.Contracts.ServiceContracts;
    using HRP.Data;
    using HRP.Data.Repositories;
    using HRP.Services;
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
	
    public class DefaultRegistry : Registry {
        #region Constructors and Destructors

        public DefaultRegistry() {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
					scan.With(new ControllerConvention());
                });
            For<IUnitOfWorkFactory>().Use<UnitOfWorkFactory>();
            For<IUnitOfWork>().Use<UnitOfWork>().AlwaysUnique();
            //For<ITransactionFactory>().Use<TransactionFactory>();
            //For<IDbTransaction>().Use(t => t.GetInstance<ITransactionFactory>().GetTransaction());
            For<IDboContextFactory>().Use<DboContextFactory>();
            For<IDboContext>().Use(d => d.GetInstance<IDboContextFactory>().GetContext());
            Profile(Constants.UnitOfWork, p => p.For<IDboContext>().Use(c => c.GetInstance<IDboContextFactory>().GetContext()));
            For<ICandidateRepository>().Use<CandidateRepository>();
            For<ICandidateService>().Use<CandidateService>();
        }

        #endregion
    }
}