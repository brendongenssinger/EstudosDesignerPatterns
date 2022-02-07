using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Designer_Pattern.PluralSigth_Adapter.Model
{
    public class PatternRenderer
    {
        private readonly IDataPatternRendererAdapter _dataPatternRendererAdapter;
        public PatternRenderer(IDataPatternRendererAdapter dataPatternRendererAdapter)
        {
            _dataPatternRendererAdapter = dataPatternRendererAdapter;
        }

        public PatternRenderer() : this(new DataPatternRendererAdapter())
        {
            
        }

        
        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return _dataPatternRendererAdapter.ListPatterns(patterns);
        }
    }

    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }

    class DataPatternRendererAdapter : IDataPatternRendererAdapter
    {
        private DataRender _dataRenderer;
        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            var adapter = new PatternCollecionDbAdapter(patterns);
            _dataRenderer = new DataRender(adapter);
            var writer = new StringWriter();
            _dataRenderer.Render(writer);
            return writer.ToString();
        }
    }

    class PatternCollecionDbAdapter : IDbDataAdapter
    {
        private readonly IEnumerable<Pattern> _patterns;
        public PatternCollecionDbAdapter(IEnumerable<Pattern> patterns)
        {
            _patterns = patterns;
        }
        

        public ITableMappingCollection TableMappings => throw new NotImplementedException();

        public int Fill(DataSet dataSet)
        {
            var myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn("ID", typeof(int)));
            myDataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            myDataTable.Columns.Add(new DataColumn("Description", typeof(string)));

            /*
             * Salvando os registros na linha
             */
            foreach (var pattern in _patterns)
            {
                var myRow = myDataTable.NewRow();
                myRow[0] = pattern.Id;
                myRow[1] = pattern.Name;
                myRow[2] = pattern.Description;
                myDataTable.Rows.Add(myRow); // Adicionando os dados na tabela myRow;
            }
            dataSet.Tables.Add(myDataTable); // Adicionando os dados no dataSet;     
            dataSet.AcceptChanges();
            return 1;
        }
        #region Not IMplemented
        public IDbCommand SelectCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand InsertCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand UpdateCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

} 