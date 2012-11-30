﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.MicroKernel.Registration;
using Glass.Mapper.Pipelines.ObjectConstruction;
using Glass.Mapper.Pipelines.TypeResolver;
using Castle.Windsor;

namespace Glass.Mapper
{
    public abstract class GlassCastleConfigBase : IGlassConfiguration
    {
        public virtual void Setup(WindsorContainer container, string contextName)
        {
            container.Register(
                Component.For<ObjectFactory>()
                );
        }

        public abstract IEnumerable<ComponentRegistration<IObjectConstructionTask>> ObjectContructionTasks(string contextName);
        public abstract IEnumerable<ComponentRegistration<ITypeResolverTask>> TypeResolverTasks(string contextName);
        public abstract IEnumerable<ComponentRegistration<ITypeResolverTask>> ConfigurationResolverTasks(string contextName);
       
    }
}