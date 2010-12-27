﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("WikipediaModel", "FK_Articles_Domains", "Domain", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Wikipedia.Data.Domain), "Article", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Wikipedia.Data.Article), true)]
[assembly: EdmRelationshipAttribute("WikipediaModel", "FK_Versions_Articles", "Article", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Wikipedia.Data.Article), "Version", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Wikipedia.Data.Version), true)]

#endregion

namespace Wikipedia.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WikipediaEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new WikipediaEntities object using the connection string found in the 'WikipediaEntities' section of the application configuration file.
        /// </summary>
        public WikipediaEntities() : base("name=WikipediaEntities", "WikipediaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WikipediaEntities object.
        /// </summary>
        public WikipediaEntities(string connectionString) : base(connectionString, "WikipediaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WikipediaEntities object.
        /// </summary>
        public WikipediaEntities(EntityConnection connection) : base(connection, "WikipediaEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Article> Articles
        {
            get
            {
                if ((_Articles == null))
                {
                    _Articles = base.CreateObjectSet<Article>("Articles");
                }
                return _Articles;
            }
        }
        private ObjectSet<Article> _Articles;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Domain> Domains
        {
            get
            {
                if ((_Domains == null))
                {
                    _Domains = base.CreateObjectSet<Domain>("Domains");
                }
                return _Domains;
            }
        }
        private ObjectSet<Domain> _Domains;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Image> Images
        {
            get
            {
                if ((_Images == null))
                {
                    _Images = base.CreateObjectSet<Image>("Images");
                }
                return _Images;
            }
        }
        private ObjectSet<Image> _Images;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Version> Versions
        {
            get
            {
                if ((_Versions == null))
                {
                    _Versions = base.CreateObjectSet<Version>("Versions");
                }
                return _Versions;
            }
        }
        private ObjectSet<Version> _Versions;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Articles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToArticles(Article article)
        {
            base.AddObject("Articles", article);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Domains EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDomains(Domain domain)
        {
            base.AddObject("Domains", domain);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Images EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToImages(Image image)
        {
            base.AddObject("Images", image);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Versions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToVersions(Version version)
        {
            base.AddObject("Versions", version);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WikipediaModel", Name="Article")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Article : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Article object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="domainId">Initial value of the DomainId property.</param>
        /// <param name="isProtected">Initial value of the IsProtected property.</param>
        /// <param name="createDate">Initial value of the CreateDate property.</param>
        public static Article CreateArticle(global::System.Int32 id, global::System.Int32 domainId, global::System.Boolean isProtected, global::System.DateTime createDate)
        {
            Article article = new Article();
            article.Id = id;
            article.DomainId = domainId;
            article.IsProtected = isProtected;
            article.CreateDate = createDate;
            return article;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DomainId
        {
            get
            {
                return _DomainId;
            }
            set
            {
                OnDomainIdChanging(value);
                ReportPropertyChanging("DomainId");
                _DomainId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DomainId");
                OnDomainIdChanged();
            }
        }
        private global::System.Int32 _DomainId;
        partial void OnDomainIdChanging(global::System.Int32 value);
        partial void OnDomainIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsProtected
        {
            get
            {
                return _IsProtected;
            }
            set
            {
                OnIsProtectedChanging(value);
                ReportPropertyChanging("IsProtected");
                _IsProtected = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsProtected");
                OnIsProtectedChanged();
            }
        }
        private global::System.Boolean _IsProtected;
        partial void OnIsProtectedChanging(global::System.Boolean value);
        partial void OnIsProtectedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                OnCreateDateChanging(value);
                ReportPropertyChanging("CreateDate");
                _CreateDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreateDate");
                OnCreateDateChanged();
            }
        }
        private global::System.DateTime _CreateDate;
        partial void OnCreateDateChanging(global::System.DateTime value);
        partial void OnCreateDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WikipediaModel", "FK_Articles_Domains", "Domain")]
        public Domain Domain
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Domain>("WikipediaModel.FK_Articles_Domains", "Domain").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Domain>("WikipediaModel.FK_Articles_Domains", "Domain").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Domain> DomainReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Domain>("WikipediaModel.FK_Articles_Domains", "Domain");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Domain>("WikipediaModel.FK_Articles_Domains", "Domain", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WikipediaModel", "FK_Versions_Articles", "Version")]
        public EntityCollection<Version> Versions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Version>("WikipediaModel.FK_Versions_Articles", "Version");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Version>("WikipediaModel.FK_Versions_Articles", "Version", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WikipediaModel", Name="Domain")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Domain : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Domain object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Domain CreateDomain(global::System.Int32 id, global::System.String name)
        {
            Domain domain = new Domain();
            domain.Id = id;
            domain.Name = name;
            return domain;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WikipediaModel", "FK_Articles_Domains", "Article")]
        public EntityCollection<Article> Articles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Article>("WikipediaModel.FK_Articles_Domains", "Article");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Article>("WikipediaModel.FK_Articles_Domains", "Article", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WikipediaModel", Name="Image")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Image : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Image object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="content">Initial value of the Content property.</param>
        /// <param name="contentType">Initial value of the ContentType property.</param>
        /// <param name="contentLength">Initial value of the ContentLength property.</param>
        public static Image CreateImage(global::System.Int32 id, global::System.Byte[] content, global::System.String contentType, global::System.Int32 contentLength)
        {
            Image image = new Image();
            image.Id = id;
            image.Content = content;
            image.ContentType = contentType;
            image.ContentLength = contentLength;
            return image;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] Content
        {
            get
            {
                return StructuralObject.GetValidValue(_Content);
            }
            set
            {
                OnContentChanging(value);
                ReportPropertyChanging("Content");
                _Content = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Content");
                OnContentChanged();
            }
        }
        private global::System.Byte[] _Content;
        partial void OnContentChanging(global::System.Byte[] value);
        partial void OnContentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ContentType
        {
            get
            {
                return _ContentType;
            }
            set
            {
                OnContentTypeChanging(value);
                ReportPropertyChanging("ContentType");
                _ContentType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ContentType");
                OnContentTypeChanged();
            }
        }
        private global::System.String _ContentType;
        partial void OnContentTypeChanging(global::System.String value);
        partial void OnContentTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ContentLength
        {
            get
            {
                return _ContentLength;
            }
            set
            {
                OnContentLengthChanging(value);
                ReportPropertyChanging("ContentLength");
                _ContentLength = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ContentLength");
                OnContentLengthChanged();
            }
        }
        private global::System.Int32 _ContentLength;
        partial void OnContentLengthChanging(global::System.Int32 value);
        partial void OnContentLengthChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WikipediaModel", Name="Version")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Version : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Version object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="articleId">Initial value of the ArticleId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="content">Initial value of the Content property.</param>
        /// <param name="createDate">Initial value of the CreateDate property.</param>
        public static Version CreateVersion(global::System.Int32 id, global::System.Int32 articleId, global::System.String name, global::System.String content, global::System.DateTime createDate)
        {
            Version version = new Version();
            version.Id = id;
            version.ArticleId = articleId;
            version.Name = name;
            version.Content = content;
            version.CreateDate = createDate;
            return version;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ArticleId
        {
            get
            {
                return _ArticleId;
            }
            set
            {
                OnArticleIdChanging(value);
                ReportPropertyChanging("ArticleId");
                _ArticleId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ArticleId");
                OnArticleIdChanged();
            }
        }
        private global::System.Int32 _ArticleId;
        partial void OnArticleIdChanging(global::System.Int32 value);
        partial void OnArticleIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Content
        {
            get
            {
                return _Content;
            }
            set
            {
                OnContentChanging(value);
                ReportPropertyChanging("Content");
                _Content = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Content");
                OnContentChanged();
            }
        }
        private global::System.String _Content;
        partial void OnContentChanging(global::System.String value);
        partial void OnContentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                OnCreateDateChanging(value);
                ReportPropertyChanging("CreateDate");
                _CreateDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreateDate");
                OnCreateDateChanged();
            }
        }
        private global::System.DateTime _CreateDate;
        partial void OnCreateDateChanging(global::System.DateTime value);
        partial void OnCreateDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WikipediaModel", "FK_Versions_Articles", "Article")]
        public Article Article
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Article>("WikipediaModel.FK_Versions_Articles", "Article").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Article>("WikipediaModel.FK_Versions_Articles", "Article").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Article> ArticleReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Article>("WikipediaModel.FK_Versions_Articles", "Article");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Article>("WikipediaModel.FK_Versions_Articles", "Article", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
