/*
 * self-managed-osdu
 * Rest API Documentation for Self Managed OSDU
 *
 * OpenAPI spec version: 0.11.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * Patch api query specific information
 */
@ApiModel(description = "Patch api query specific information")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2022-01-06T19:58:30.495Z")
public class StorageRecordQuery {
  @SerializedName("ids")
  private List<String> ids = new ArrayList<String>();

  public StorageRecordQuery ids(List<String> ids) {
    this.ids = ids;
    return this;
  }

  public StorageRecordQuery addIdsItem(String idsItem) {
    this.ids.add(idsItem);
    return this;
  }

   /**
   * Records ids for whom patch operations going to be applied
   * @return ids
  **/
  @ApiModelProperty(required = true, value = "Records ids for whom patch operations going to be applied")
  public List<String> getIds() {
    return ids;
  }

  public void setIds(List<String> ids) {
    this.ids = ids;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StorageRecordQuery storageRecordQuery = (StorageRecordQuery) o;
    return Objects.equals(this.ids, storageRecordQuery.ids);
  }

  @Override
  public int hashCode() {
    return Objects.hash(ids);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StorageRecordQuery {\n");
    
    sb.append("    ids: ").append(toIndentedString(ids)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

